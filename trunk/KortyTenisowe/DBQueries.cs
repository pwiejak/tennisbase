using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KortyTenisowe
{
    public class DBQueries
    {
        /* Metoda sprawdzająca poprawność próby zalogowania do programu */
        public static bool Logowanie(string Login, string haslo)
        {
            bool Poprawny = false;
            try
            {
                /* Wyszukanie użytkownika o podanym loginie i haśle */
                Uzytkownicy_Systemu user = (from Uzytkownicy_Systemu users in Inzynierka1Entities.ENTITY.Uzytkownicy_Systemu where String.Compare(Login, users.Login, true) == 0 select users).FirstOrDefault();
                if (String.Compare(user.Haslo, haslo, true) == 0)
                {
                    Poprawny = true;
                    KortyTenisowe.LogowanieForm.poziomUprawnien = user.Uprawnienia.Value;
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Błąd: " + e.Message);
            }

            return Poprawny;
        }

        public static int PobierzIDUzytkownika(string login)
        {
            Uzytkownicy_Systemu uzytkownik = new Uzytkownicy_Systemu();
            try
            {
                uzytkownik = (from Uzytkownicy_Systemu szukanyUzytkownik in Inzynierka1Entities.ENTITY.Uzytkownicy_Systemu
                              where String.Compare(login, szukanyUzytkownik.Login, true) == 0
                              select szukanyUzytkownik).ToList().LastOrDefault();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Wystąpił błąd: " + e.Message);
            }
            return uzytkownik.ID_Pracownika;
        }

        /* Metoda dodająca pracownika i konta użytkownika dla tego pracownika do bazy */
        public static bool DodajPracownika(string Imie, string Nazwisko, string Telefon,
                                            string Login, int Uprawnienie, string Haslo)
        {
            /* Stworzenie obiektów pracownika i użytkownika */
            bool success = false;
            Pracownicy pracownik = new Pracownicy();
            pracownik.Imie = Imie;
            pracownik.Nazwisko = Nazwisko;
            pracownik.Telefon = Telefon;
            Uzytkownicy_Systemu Uzytkownik = new Uzytkownicy_Systemu();
            Uzytkownik.Login = Login;
            Uzytkownik.Haslo = Haslo;
            Uzytkownik.Uprawnienia = Uprawnienie;

            try
            {
                /* Dodanie pracownika i zapisanie zmian w bazie */
                Inzynierka1Entities.ENTITY.AddToPracownicy(pracownik);
                Inzynierka1Entities.ENTITY.SaveChanges();

                /* Pobranie ID ostatnio dodanego pracownika */
                Pracownicy dodany = (from Pracownicy pracownicy in Inzynierka1Entities.ENTITY.Pracownicy
                                     where String.Compare(pracownik.Nazwisko, pracownicy.Nazwisko, true) == 0
                                     select pracownicy).ToList().LastOrDefault();

                /* Dodanie konta użytkownika dla stworzonego pracownika i zapisanie zmian w bazie */
                Uzytkownik.ID_Pracownika = dodany.Id_Pracownika;
                Inzynierka1Entities.ENTITY.AddToUzytkownicy_Systemu(Uzytkownik);
                Inzynierka1Entities.ENTITY.SaveChanges();
            }
            catch (Exception e)
            {
                success = false;
                System.Windows.Forms.MessageBox.Show("Błąd przy dodawaniu: " + e.Message);
            }
            return success;
        }

        public static bool DodajKlienta(string Imie, string Nazwisko, string Telefon, int typKlienta)
        {
            bool result = true;
            Uzytkownicy_Kortow dodawanyUzytkownik = new Uzytkownicy_Kortow();
            dodawanyUzytkownik.Nazwisko = Nazwisko;
            dodawanyUzytkownik.Imię = Imie;
            dodawanyUzytkownik.Telefon = Telefon;
            dodawanyUzytkownik.Typ = typKlienta;

            try
            {
                Inzynierka1Entities.ENTITY.AddToUzytkownicy_Kortow(dodawanyUzytkownik);
                Inzynierka1Entities.ENTITY.SaveChanges();
            }
            catch (Exception e)
            {
                result = false;
                System.Windows.Forms.MessageBox.Show("Wystąpił błąd: " + e.Message);
            }
            return result;
        }

        public static IEnumerable<Rezerwacje_Kortow> ZwrocRezerwacjeKortowWgDaty(DateTime data)
        {
            string samaData, data1;
            data1 = data.ToString();
            samaData = data1.Substring(0, 8);

            return (from Rezerwacje_Kortow ZarezerwowaneKorty in KortyTenisowe.Inzynierka1Entities.ENTITY.Rezerwacje_Kortow
                    where ZarezerwowaneKorty.Data == data
                    select ZarezerwowaneKorty);
        }

        public static IEnumerable<Rezerwacje_Kortow> ZwrocRezerwacjeKortowWgDnia(int dzienTygodnia)
        {
            return (from Rezerwacje_Kortow ZarezerwowaneKorty in KortyTenisowe.Inzynierka1Entities.ENTITY.Rezerwacje_Kortow
                    where ZarezerwowaneKorty.Dzien_Tygodnia == dzienTygodnia
                    select ZarezerwowaneKorty);
        }

        public static IEnumerable<Uzytkownicy_Kortow> ZwrocUzytkownikowKortow()
        {
            return (from Uzytkownicy_Kortow WszyscyUzytkownicy in KortyTenisowe.Inzynierka1Entities.ENTITY.Uzytkownicy_Kortow
                    orderby WszyscyUzytkownicy.Nazwisko
                    select WszyscyUzytkownicy);
        }

        public static bool dodajRezerwacjeStala(int numerKortu, int nrDniaTygodnia, int godzinaRozpoczecia,
                                                int godzinaZakonczenia, int idKLienta, float cena, int idPracownika)
        {
            bool result = true;
            Rezerwacje_Kortow rezerwacja = new Rezerwacje_Kortow();
            rezerwacja.Nr_Kortu = numerKortu;
            rezerwacja.Dzien_Tygodnia = nrDniaTygodnia;
            rezerwacja.Data = null;
            rezerwacja.Godz_Rozpoczecia = godzinaRozpoczecia;
            rezerwacja.Godz_Zakonczenia = godzinaZakonczenia;
            rezerwacja.ID_Osoby = idKLienta;
            rezerwacja.Cena = cena;
            rezerwacja.Id_Pracownika = idPracownika;
            try
            {
                Inzynierka1Entities.ENTITY.AddToRezerwacje_Kortow(rezerwacja);
                Inzynierka1Entities.ENTITY.SaveChanges();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Error podczas dodawania rezerwacji: " + e.Message);
                result = false;
            }
            return result;
        }

        public static bool dodajRezerwacjeJednorazowa(int numerKortu, DateTime dataRezerwacji, int godzinaRozpoczecia,
                                                int godzinaZakonczenia, int idKLienta, float cena, int idPracownika)
        {
            bool result = true;
            Rezerwacje_Kortow rezerwacja = new Rezerwacje_Kortow();
            rezerwacja.Nr_Kortu = numerKortu;
            rezerwacja.Data = dataRezerwacji;
            rezerwacja.Godz_Rozpoczecia = godzinaRozpoczecia;
            rezerwacja.Godz_Zakonczenia = godzinaZakonczenia;
            rezerwacja.ID_Osoby = idKLienta;
            rezerwacja.Cena = cena;
            rezerwacja.Id_Pracownika = idPracownika;
            try
            {
                Inzynierka1Entities.ENTITY.AddToRezerwacje_Kortow(rezerwacja);
                Inzynierka1Entities.ENTITY.SaveChanges();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Error podczas dodawania rezerwacji: " + e.Message);
                result = false;
            }
            return result;
        }

        public static IEnumerable<Rezerwacje_Kortow> ZwrocRezerwacjeDoWalidacji(DateTime data)
        {
            return (from Rezerwacje_Kortow sprawdzanaRezerwacja in Inzynierka1Entities.ENTITY.Rezerwacje_Kortow
                    where sprawdzanaRezerwacja.Data == data
                    select sprawdzanaRezerwacja);
        }

        public static Rezerwacje_Kortow ZwrocKonkretnaRezerwacje(DateTime data, int dzienTygodnia, int kort, int godzina)
        {
            if (data != null)
            {
                return (from Rezerwacje_Kortow rezerwacja in Inzynierka1Entities.ENTITY.Rezerwacje_Kortow
                        where rezerwacja.Data == data && rezerwacja.Nr_Kortu == kort && rezerwacja.Godz_Rozpoczecia == godzina
                        select rezerwacja).FirstOrDefault();
            }
            else
            {
                return (from Rezerwacje_Kortow rezerwacja in Inzynierka1Entities.ENTITY.Rezerwacje_Kortow
                        where rezerwacja.Dzien_Tygodnia == dzienTygodnia && rezerwacja.Nr_Kortu == kort && rezerwacja.Godz_Rozpoczecia == godzina
                        select rezerwacja).FirstOrDefault();
            }
        }

        public static IEnumerable<Typy> ZwrocTypy()
        {
            return (from Typy zwracaneTypy in Inzynierka1Entities.ENTITY.Typy
                    select zwracaneTypy);
        }

        public static bool dodajSprzet(int indeksTypu, string marka, string model, string opis)
        {
            bool success = true;
            Sprzet dodawanySprzet = new Sprzet();
            dodawanySprzet.Typ = indeksTypu + 1;
            dodawanySprzet.Marka = marka;
            dodawanySprzet.Model = model;
            if (opis != null)
                dodawanySprzet.Opis = opis;
            try
            {
                Inzynierka1Entities.ENTITY.AddToSprzet(dodawanySprzet);
                Inzynierka1Entities.ENTITY.SaveChanges();
            }
            catch (Exception e)
            {
                success = false;
                System.Windows.Forms.MessageBox.Show("Wystąpił błąd: " + e.Message);
            }

            return success;
        }

        public static IEnumerable<Sprzet> zwrocSprzetWgTypu(int indeksTypu)
        {
            int m_indeks = indeksTypu;
            return (from Sprzet zwracanySprzet in Inzynierka1Entities.ENTITY.Sprzet
                    where zwracanySprzet.Typ == m_indeks
                    select zwracanySprzet);
        }

        public static IEnumerable<Stan_Magazynowy> zwrocStanMagazynowyWgTypu(int indeksTypu)
        {
            int m_indeks = indeksTypu;
            return (from Stan_Magazynowy zwracanySprzet in Inzynierka1Entities.ENTITY.Stan_Magazynowy
                    join Sprzet sprzet in Inzynierka1Entities.ENTITY.Sprzet on zwracanySprzet.ID_Produktu equals sprzet.ID_Produktu
                    where sprzet.Typ == m_indeks
                    select zwracanySprzet);
        }

        public static IEnumerable<Wypozyczone> zwrocWypozyczenia()
        {
            return (from Wypozyczone wypozyczenia in Inzynierka1Entities.ENTITY.Wypozyczone
                    select wypozyczenia);
        }

        public static IEnumerable<Stan_Magazynowy> zwrocPrzedmiotWgID(int id)
        {
            return (from Stan_Magazynowy zwracanyPrzedmiot in Inzynierka1Entities.ENTITY.Stan_Magazynowy
                    where zwracanyPrzedmiot.ID_Produktu == id
                    select zwracanyPrzedmiot);
        }

        public static bool dodajNowaKategorie(string nazwaKategorii)
        {
            Typy dodawanyTyp = new Typy();
            dodawanyTyp.Nazwa = nazwaKategorii;
            bool success = true;
            try
            {
                Inzynierka1Entities.ENTITY.AddToTypy(dodawanyTyp);
                Inzynierka1Entities.ENTITY.SaveChanges();
            }
            catch (Exception e)
            {
                success = false;
                System.Windows.Forms.MessageBox.Show("Wystąpił bład: " + e.Message);
            }
            return success;
        }

        public static bool dodajSprzetNaMagazyn(int id, int typSprzedazy, int ilosc, string rozmiar, string kolor, float cena)
        {
            bool success = true;
            Stan_Magazynowy dodawanySprzet = new Stan_Magazynowy();
            dodawanySprzet.ID_Produktu = id;
            dodawanySprzet.Typ_Sprzedazy = typSprzedazy;
            dodawanySprzet.Ilosc = ilosc;
            dodawanySprzet.Rozmiar = rozmiar;
            dodawanySprzet.Kolor = kolor;
            dodawanySprzet.Cena = cena;

            try
            {
                Inzynierka1Entities.ENTITY.AddToStan_Magazynowy(dodawanySprzet);
                Inzynierka1Entities.ENTITY.SaveChanges();
            }
            catch (Exception exc)
            {
                success = false;
                System.Windows.Forms.MessageBox.Show(exc.Message);
            }

            return success;
        }

        public static int zwrocIloscStanuMagazynu(int id)
        {
            return (from Stan_Magazynowy sprawdzanySprzet in Inzynierka1Entities.ENTITY.Stan_Magazynowy
                    where sprawdzanySprzet.Nr_Przedmiotu == id
                    select sprawdzanySprzet.Ilosc).First();
        }

        public static bool zmienIloscStanuMagazynowego(int id, int ilosc)
        {
            bool success = true;
            Stan_Magazynowy zmienianyObiekt = new Stan_Magazynowy();
            try
            {
                zmienianyObiekt = (from Stan_Magazynowy sprawdzanySprzet in Inzynierka1Entities.ENTITY.Stan_Magazynowy
                                   where sprawdzanySprzet.Nr_Przedmiotu == id
                                   select sprawdzanySprzet).First();
                zmienianyObiekt.Ilosc = ilosc;
                Inzynierka1Entities.ENTITY.SaveChanges();
            }
            catch (Exception exc)
            {
                success = false;
                System.Windows.Forms.MessageBox.Show(exc.Message);
            }

            return success;
        }

        public static bool UsunPrzedmiotZMagazynu(int id)
        {
            bool success = true;
            Stan_Magazynowy usuwanyObiekt = new Stan_Magazynowy();
            try
            {
                usuwanyObiekt = (from Stan_Magazynowy sprawdzanySprzet in Inzynierka1Entities.ENTITY.Stan_Magazynowy
                                 where sprawdzanySprzet.Nr_Przedmiotu == id
                                 select sprawdzanySprzet).First();
                Inzynierka1Entities.ENTITY.Stan_Magazynowy.DeleteObject(usuwanyObiekt);
                Inzynierka1Entities.ENTITY.SaveChanges();
            }
            catch (Exception exc)
            {
                success = false;
                System.Windows.Forms.MessageBox.Show(exc.Message);
            }

            return success;
        }

        public static bool DodajWypozyczenie(int idPrzedmiotu, int idKlienta, DateTime dataRozpoczecia, int godzRozpoczecia,
                                                DateTime dataZakonczenia, int godzZakonczenia)
        {
            bool success = true;

            Wypozyczone dodawaneWypozyczenie = new Wypozyczone();
            dodawaneWypozyczenie.ID_Przedmiotu = idPrzedmiotu;
            dodawaneWypozyczenie.Id_Klienta = idKlienta;
            dodawaneWypozyczenie.Data_Rozpoczecia = dataRozpoczecia;
            dodawaneWypozyczenie.Data_Zakonczenia = dataZakonczenia;

            if (dataRozpoczecia != dataZakonczenia)
            {
                dodawaneWypozyczenie.Godzina_Rozpoczecia = null;
                dodawaneWypozyczenie.Godzina_Zakonczenia = null;
            }
            else
            {
                dodawaneWypozyczenie.Godzina_Rozpoczecia = godzRozpoczecia;
                dodawaneWypozyczenie.Godzina_Zakonczenia = godzZakonczenia;
            }

            try
            {
                Inzynierka1Entities.ENTITY.AddToWypozyczone(dodawaneWypozyczenie);
                Inzynierka1Entities.ENTITY.SaveChanges();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                success = false;
            }

            return success;
        }

        public static Uzytkownicy_Kortow zwrocKonkretnegoKLienta(int idKLienta)
        {
            return (from Uzytkownicy_Kortow klient in Inzynierka1Entities.ENTITY.Uzytkownicy_Kortow
                    where klient.ID == idKLienta
                    select klient).First();
        }

        public static bool DodajZawodnika(string Imie, string Nazwisko, string Telefon, string Email)
        {
            bool result = true;
            Zawodnicy dodawanyZawodnik = new Zawodnicy();
            dodawanyZawodnik.Nazwisko = Nazwisko;
            dodawanyZawodnik.Imie = Imie;
            dodawanyZawodnik.Telefon = Telefon;
            dodawanyZawodnik.Email = Email;

            try
            {
                Inzynierka1Entities.ENTITY.AddToZawodnicy(dodawanyZawodnik);
                Inzynierka1Entities.ENTITY.SaveChanges();
            }
            catch (Exception e)
            {
                result = false;
                System.Windows.Forms.MessageBox.Show("Wystąpił błąd: " + e.Message);
            }
            return result;
        }


        public static Zawodnicy ZwrocKonkretnegoZawodnika(int id)
        {
            return (from Zawodnicy szukanyZawodnik in Inzynierka1Entities.ENTITY.Zawodnicy
                    where szukanyZawodnik.ID_Zawodnika == id
                    select szukanyZawodnik).First();

        }

        public static bool EdytujZawodnika(int id, string Imie, string Nazwisko, string Telefon, string Email)
        {
            bool success = true;
            Zawodnicy zmienianyZawodnik = new Zawodnicy();
            try
            {
                zmienianyZawodnik = (from Zawodnicy szukanyZawodnik in Inzynierka1Entities.ENTITY.Zawodnicy
                                     where szukanyZawodnik.ID_Zawodnika == id
                                     select szukanyZawodnik).First();
                zmienianyZawodnik.Nazwisko = Nazwisko;
                zmienianyZawodnik.Imie = Imie;
                zmienianyZawodnik.Telefon = Telefon;
                zmienianyZawodnik.Email = Email;

                Inzynierka1Entities.ENTITY.SaveChanges();
            }
            catch (Exception exc)
            {
                success = false;
                System.Windows.Forms.MessageBox.Show(exc.Message);
            }

            return success;
        }

        public static bool UsunZawodnika(int id)
        {
            bool success = true;
            Zawodnicy usuwanyZawodnik = new Zawodnicy();
            try
            {
                usuwanyZawodnik = (from Zawodnicy sprawdzanyZawodnik in Inzynierka1Entities.ENTITY.Zawodnicy
                                   where sprawdzanyZawodnik.ID_Zawodnika == id
                                   select sprawdzanyZawodnik).First();
                Inzynierka1Entities.ENTITY.Zawodnicy.DeleteObject(usuwanyZawodnik);
                Inzynierka1Entities.ENTITY.SaveChanges();
            }
            catch (Exception exc)
            {
                success = false;
                System.Windows.Forms.MessageBox.Show(exc.Message);
            }

            return success;
        }

        public static bool DodajTurniej(int Kategoria, DateTime dataRozpoczecia, DateTime dataZakonczenia, string Nazwa, string Opis)
        {
            bool success = true;

            Turnieje dodawanyTurniej = new Turnieje();
            dodawanyTurniej.Kategoria = Kategoria;
            dodawanyTurniej.DataRozp = dataRozpoczecia;
            dodawanyTurniej.DataZak = dataZakonczenia;
            dodawanyTurniej.Nazwa = Nazwa;
            dodawanyTurniej.Opis = Opis;


            try
            {
                Inzynierka1Entities.ENTITY.AddToTurnieje(dodawanyTurniej);
                Inzynierka1Entities.ENTITY.SaveChanges();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                success = false;
            }

            return success;
        }



        public static Turnieje ZwrocKonkretnyTurniej(int id)
        {
            return (from Turnieje szukanyTurniej in Inzynierka1Entities.ENTITY.Turnieje
                    where szukanyTurniej.ID_Turnieju == id
                    select szukanyTurniej).First();

        }

        public static bool EdytujTurniej(int id, int Kategoria, DateTime dataRozpoczecia, DateTime dataZakonczenia, string Nazwa, string Opis)
        {
            bool success = true;
            Turnieje zmienianyTurniej = new Turnieje();
            try
            {
                zmienianyTurniej = (from Turnieje szukanyTurniej in Inzynierka1Entities.ENTITY.Turnieje
                                    where szukanyTurniej.ID_Turnieju == id
                                    select szukanyTurniej).First();
                zmienianyTurniej.Kategoria = Kategoria;
                zmienianyTurniej.DataRozp = dataRozpoczecia;
                zmienianyTurniej.DataZak = dataZakonczenia;
                zmienianyTurniej.Nazwa = Nazwa;
                zmienianyTurniej.Opis = Opis;
                Inzynierka1Entities.ENTITY.SaveChanges();
            }
            catch (Exception exc)
            {
                success = false;
                System.Windows.Forms.MessageBox.Show(exc.Message);
            }

            return success;
        }

        public static bool EdytujWynik(int id, string set1, string set2, string set3, string set4, string set5)
        {
            bool success = true;
            Mecze zmienianyWynik = new Mecze();
            try
            {
                zmienianyWynik = (from Mecze szukanyWynik in Inzynierka1Entities.ENTITY.Mecze
                                  where szukanyWynik.ID_Meczu == id
                                  select szukanyWynik).First();
                zmienianyWynik.Set1 = set1;
                zmienianyWynik.Set2 = set2;
                zmienianyWynik.Set3 = set3;
                zmienianyWynik.Set4 = set4;
                zmienianyWynik.Set5 = set5;
                Inzynierka1Entities.ENTITY.SaveChanges();
            }
            catch (Exception exc)
            {
                success = false;
                System.Windows.Forms.MessageBox.Show(exc.Message);
            }

            return success;
        }

        public static bool UsunTurniej(int id)
        {
            bool success = true;
            Turnieje usuwanyTurniej = new Turnieje();
            try
            {
                usuwanyTurniej = (from Turnieje sprawdzanyTurniej in Inzynierka1Entities.ENTITY.Turnieje
                                  where sprawdzanyTurniej.ID_Turnieju == id
                                  select sprawdzanyTurniej).First();
                Inzynierka1Entities.ENTITY.Turnieje.DeleteObject(usuwanyTurniej);
                Inzynierka1Entities.ENTITY.SaveChanges();
            }
            catch (Exception exc)
            {
                success = false;
                System.Windows.Forms.MessageBox.Show(exc.Message);
            }

            return success;
        }

        public static IEnumerable<Turnieje> ZwrocTurnieje()
        {
            return (from Turnieje WszystkieTurnieje in Inzynierka1Entities.ENTITY.Turnieje
                    orderby WszystkieTurnieje.ID_Turnieju
                    select WszystkieTurnieje);
        }

        public static IEnumerable<Zawodnicy> ZwrocWszystkichZawodnikow()
        {
            return (from Zawodnicy wszyscyZawodnicy in Inzynierka1Entities.ENTITY.Zawodnicy
                    select wszyscyZawodnicy);
        }


        public static bool CzyJuzGra(int idtur, int idzaw)
        {
            return (from ListaGraczy sprawdzCzyGra in Inzynierka1Entities.ENTITY.ListaGraczy
                    where (sprawdzCzyGra.ID_Turnieju == idtur) && (sprawdzCzyGra.ID_Zawodnika == idzaw)
                    select sprawdzCzyGra).Any();

        }

        public static bool DodajZawodnikaDoTurnieju(int idtur, int idzaw)
        {
            bool success = true;

            ListaGraczy dodawanyZawodnik = new ListaGraczy();
            dodawanyZawodnik.ID_Turnieju = idtur;
            dodawanyZawodnik.ID_Zawodnika = idzaw;


            try
            {
                Inzynierka1Entities.ENTITY.AddToListaGraczy(dodawanyZawodnik);
                Inzynierka1Entities.ENTITY.SaveChanges();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                success = false;
            }

            return success;
        }

        public static IEnumerable<ListaGraczy> ZwrocZawodnikow(int id)
        {
            return (from ListaGraczy ZawodnicyTurnieju in Inzynierka1Entities.ENTITY.ListaGraczy
                    where ZawodnicyTurnieju.ID_Turnieju == id
                    select ZawodnicyTurnieju);
        }


        public static bool ZaplanujMecz(int ID_Turnieju, int Zawodnik1, int Zawodnik2)
        {
            bool success = true;

            Mecze dodawanyMecz = new Mecze();
            dodawanyMecz.ID_Turnieju = ID_Turnieju;
            dodawanyMecz.Zawodnik1 = Zawodnik1;
            dodawanyMecz.Zawodnik2 = Zawodnik2;
            dodawanyMecz.CzyRozegrany = 0;



            try
            {
                Inzynierka1Entities.ENTITY.AddToMecze(dodawanyMecz);
                Inzynierka1Entities.ENTITY.SaveChanges();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                success = false;
            }

            return success;
        }


        public static IEnumerable<Mecze> ZwrocZaplanowaneMecze(int id)
        {
            return (from Mecze MeczeTurnieju in Inzynierka1Entities.ENTITY.Mecze
                    where (MeczeTurnieju.ID_Turnieju == id && MeczeTurnieju.CzyRozegrany == 0)
                    select MeczeTurnieju);
        }

        public static IEnumerable<Mecze> zwrocRozegrane(int id)
        {
            return (from Mecze MeczeTurnieju in Inzynierka1Entities.ENTITY.Mecze
                    where (MeczeTurnieju.ID_Turnieju == id && MeczeTurnieju.CzyRozegrany == 1)
                    select MeczeTurnieju);
        }


        public static bool UsunMecz(int id)
        {
            bool success = true;
            Mecze usuwanyMecz = new Mecze();
            try
            {
                usuwanyMecz = (from Mecze sprawdzanyMecz in Inzynierka1Entities.ENTITY.Mecze
                               where sprawdzanyMecz.ID_Meczu == id
                               select sprawdzanyMecz).First();
                Inzynierka1Entities.ENTITY.Mecze.DeleteObject(usuwanyMecz);
                Inzynierka1Entities.ENTITY.SaveChanges();
            }
            catch (Exception exc)
            {
                success = false;
                System.Windows.Forms.MessageBox.Show(exc.Message);
            }

            return success;
        }


        public static Mecze ZwrocKonkretnyMecz(int id)
        {
            return (from Mecze szukanyMecz in Inzynierka1Entities.ENTITY.Mecze
                    where szukanyMecz.ID_Meczu == id
                    select szukanyMecz).First();

        }

        public static bool DodajWynik(int id, string set1, string set2, string set3, string set4, string set5)
        {
            bool success = true;
            Mecze dodawanyWynik = new Mecze();
            try
            {
                dodawanyWynik = (from Mecze szukanyMecz in Inzynierka1Entities.ENTITY.Mecze
                                 where szukanyMecz.ID_Meczu == id
                                 select szukanyMecz).First();
                dodawanyWynik.Set1 = set1;
                dodawanyWynik.Set2 = set2;
                dodawanyWynik.Set3 = set3;
                dodawanyWynik.Set4 = set4;
                dodawanyWynik.Set5 = set5;
                dodawanyWynik.CzyRozegrany = 1;

                Inzynierka1Entities.ENTITY.SaveChanges();
            }
            catch (Exception exc)
            {
                success = false;
                System.Windows.Forms.MessageBox.Show(exc.Message);
            }

            return success;
        }

        public static bool DodajKlasyfikacje(int ID_Turnieju, int CzyGeneralna, int Miejsce, int Punkty, int ID_Zawodnika)
        {

            bool success = true;

            Klasyfikacje dodawanaKlasyfikacja = new Klasyfikacje();
            dodawanaKlasyfikacja.ID_Turnieju = ID_Turnieju;
            dodawanaKlasyfikacja.CzyGeneralna = CzyGeneralna;
            dodawanaKlasyfikacja.Miejsce = Miejsce;
            dodawanaKlasyfikacja.Punkty = Punkty;
            dodawanaKlasyfikacja.ID_Zawodnika = ID_Zawodnika;

            try
            {
                Inzynierka1Entities.ENTITY.AddToKlasyfikacje(dodawanaKlasyfikacja);
                Inzynierka1Entities.ENTITY.SaveChanges();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                success = false;
            }

            return success;
        }

        public static bool DodajGeneralna(int ID_Zawodnika, int Punkty)
        {

            bool success = true;

            Generalna dodawanaGeneralna = new Generalna();
            dodawanaGeneralna.ID_Zawodnika = ID_Zawodnika;
            dodawanaGeneralna.Punkty = Punkty;

            try
            {
                Inzynierka1Entities.ENTITY.AddToGeneralna(dodawanaGeneralna);
                Inzynierka1Entities.ENTITY.SaveChanges();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                success = false;
            }

            return success;
        }

        public static bool ZaznaczonaGeneralna(Klasyfikacje czyGeneralna)
        {
            if (czyGeneralna.CzyGeneralna == 1) return true;
            else return false;
        }

        public static bool UsunKlasyfikacjePoID(int id)
        {
            bool success = true;
            Klasyfikacje usuwanaKlasyfikacja = new Klasyfikacje();
            try
            {
                usuwanaKlasyfikacja = (from Klasyfikacje sprawdzanaKlasyfikacja in Inzynierka1Entities.ENTITY.Klasyfikacje
                               where sprawdzanaKlasyfikacja.ID_Klasyfikacji == id
                               select sprawdzanaKlasyfikacja).First();
                Inzynierka1Entities.ENTITY.Klasyfikacje.DeleteObject(usuwanaKlasyfikacja);
                Inzynierka1Entities.ENTITY.SaveChanges();
            }
            catch (Exception exc)
            {
                success = false;
                System.Windows.Forms.MessageBox.Show(exc.Message);
            }

            return success;
        }

        public static Klasyfikacje ZwrocKonkretnaKlasyfikacje(int id)
        {
            return (from Klasyfikacje szukanaKlasyfikacja in Inzynierka1Entities.ENTITY.Klasyfikacje
                    where szukanaKlasyfikacja.ID_Klasyfikacji == id
                    select szukanaKlasyfikacja).First();
        }


        public static bool CzyGeneralna(int id_Zawodnika)
        {
            return (from Generalna szukanaGeneralna in Inzynierka1Entities.ENTITY.Generalna
                    where szukanaGeneralna.ID_Zawodnika == id_Zawodnika
                    select szukanaGeneralna).Any();
        }

        public static bool EdytujGeneralna(int id_Zawodnika, int Punkty)
        {
            bool success = true;
            Generalna zmienianaGeneralna = new Generalna();
            try
            {
                zmienianaGeneralna = (from Generalna szukanaGeneralna in Inzynierka1Entities.ENTITY.Generalna
                                      where szukanaGeneralna.ID_Zawodnika == id_Zawodnika
                                      select szukanaGeneralna).First();
                zmienianaGeneralna.Punkty += Punkty;
                Inzynierka1Entities.ENTITY.SaveChanges();
            }
            catch (Exception exc)
            {
                success = false;
                System.Windows.Forms.MessageBox.Show(exc.Message);
            }

            return success;
        }

        public static bool OdejmijGeneralna(int idKlasyfikacji)
        {
            bool success = true;
            int id_zaw, punkty;
            Klasyfikacje szukanaKlasyfikacja = new Klasyfikacje();

            szukanaKlasyfikacja = (from Klasyfikacje klasyfikacja in Inzynierka1Entities.ENTITY.Klasyfikacje
                                   where klasyfikacja.ID_Klasyfikacji == idKlasyfikacji
                                   select klasyfikacja).First();

            id_zaw = szukanaKlasyfikacja.ID_Zawodnika;
            punkty = Convert.ToInt32(szukanaKlasyfikacja.Punkty);                        
            
            
            Generalna zmienianaGeneralna = new Generalna();
            try
            {
                zmienianaGeneralna = (from Generalna szukanaGeneralna in Inzynierka1Entities.ENTITY.Generalna
                                      where szukanaGeneralna.ID_Zawodnika == id_zaw
                                      select szukanaGeneralna).First();
                zmienianaGeneralna.Punkty -= punkty;
                Inzynierka1Entities.ENTITY.SaveChanges();
            }
            catch (Exception exc)
            {
                success = false;
                System.Windows.Forms.MessageBox.Show(exc.Message);
            }

            return success;
        }



        public static ListaGraczy ZwrocKonkretnaLista(int idtur, int idzaw)
        {
            return (from ListaGraczy szukanaLista in Inzynierka1Entities.ENTITY.ListaGraczy
                    where szukanaLista.ID_Zawodnika == idzaw && szukanaLista.ID_Turnieju == idtur
                    select szukanaLista).First();

        }


        public static int ZwrocIDListy(ListaGraczy lista)
        {
            return lista.ID_Listy;
        }




        public static bool UsunListaGraczy(int idListy)
        {
            bool success = true;
            ListaGraczy usuwanaLista = new ListaGraczy();

            try
            {
                usuwanaLista = (from ListaGraczy szukanaLista in Inzynierka1Entities.ENTITY.ListaGraczy
                                        where szukanaLista.ID_Listy == idListy
                                        select szukanaLista).First();

                Inzynierka1Entities.ENTITY.ListaGraczy.DeleteObject(usuwanaLista);
                Inzynierka1Entities.ENTITY.SaveChanges();
                
            }
            catch (Exception exc)
            {
                success = false;
                System.Windows.Forms.MessageBox.Show(exc.Message);
            }

            return success;
        } 
                
        
        public static bool ZwrocKlasyfikacje(int id_Turnieju, int id_Zawodnika)
        {
            return (from Klasyfikacje szukanaKlasyfikacja in Inzynierka1Entities.ENTITY.Klasyfikacje
                    where (szukanaKlasyfikacja.ID_Turnieju == id_Turnieju) && (szukanaKlasyfikacja.ID_Zawodnika == id_Zawodnika)
                    select szukanaKlasyfikacja).Any();
        }

        public static IEnumerable<Klasyfikacje> ZwrocKlasyfikacjeTurnieju(int id_Turnieju)
        {
            return (from Klasyfikacje zwracanaKlasyfikacja in Inzynierka1Entities.ENTITY.Klasyfikacje
                    where (zwracanaKlasyfikacja.ID_Turnieju == id_Turnieju)
                    orderby zwracanaKlasyfikacja.Miejsce
                    select zwracanaKlasyfikacja);
        }

        public static IEnumerable<Generalna> ZwrocGeneralna()
        {
            return (from Generalna zwracanaGeneralna in Inzynierka1Entities.ENTITY.Generalna
                    orderby zwracanaGeneralna.Punkty descending
                    select zwracanaGeneralna);
        }



        public static bool CzyMecze(int id_Zawodnika)
        {
            return (from Mecze szukanyMecz in Inzynierka1Entities.ENTITY.Mecze
                    where szukanyMecz.Zawodnicy.ID_Zawodnika == id_Zawodnika || szukanyMecz.Zawodnicy1.ID_Zawodnika == id_Zawodnika
                    select szukanyMecz).Any();
        }

        public static IEnumerable<Mecze> ZwrocMeczeZawodnika(int id_Zawodnika)
        {
            return (from Mecze MeczeZawodnika in Inzynierka1Entities.ENTITY.Mecze
                    where MeczeZawodnika.Zawodnicy.ID_Zawodnika == id_Zawodnika || MeczeZawodnika.Zawodnicy1.ID_Zawodnika == id_Zawodnika
                    select MeczeZawodnika);
        }

        public static bool UsunMeczeZawodnika(IEnumerable<Mecze> zwroconeMecze)
        {
            bool success = true;
            try
            {
                foreach (Mecze usuwanyMecz in zwroconeMecze) Inzynierka1Entities.ENTITY.Mecze.DeleteObject(usuwanyMecz);
                Inzynierka1Entities.ENTITY.SaveChanges();
            }
            catch (Exception exc)
            {
                success = false;
                System.Windows.Forms.MessageBox.Show(exc.Message);
            }

            return success;
        }

        public static Generalna ZwrocGeneralnaZawodnika(int id_Zawodnika)
        {
            return (from Generalna szukanaGeneralna in Inzynierka1Entities.ENTITY.Generalna
                    where szukanaGeneralna.ID_Zawodnika == id_Zawodnika
                    select szukanaGeneralna).First();
        }

        public static bool UsunGeneralnaZawodnika(Generalna zwroconaGeneralna)
        {
            bool success = true;
            try
            {
                Inzynierka1Entities.ENTITY.Generalna.DeleteObject(zwroconaGeneralna);
                Inzynierka1Entities.ENTITY.SaveChanges();
            }
            catch (Exception exc)
            {
                success = false;
                System.Windows.Forms.MessageBox.Show(exc.Message);
            }

            return success;
        }


        public static bool CzyTurnieje(int id_Zawodnika)
        {
            return (from ListaGraczy szukanaLista in Inzynierka1Entities.ENTITY.ListaGraczy
                    where szukanaLista.ID_Zawodnika == id_Zawodnika
                    select szukanaLista).Any();
        }

        public static IEnumerable<ListaGraczy> ZwrocTurniejeZawodnika(int id_Zawodnika)
        {
            return (from ListaGraczy TurniejeZawodnika in Inzynierka1Entities.ENTITY.ListaGraczy
                    where TurniejeZawodnika.ID_Zawodnika == id_Zawodnika
                    select TurniejeZawodnika);
        }


        public static bool UsunTurniejeZawodnika(IEnumerable<ListaGraczy> zwroconaLista)
        {
            bool success = true;
            try
            {
                foreach (ListaGraczy usuwanaLista in zwroconaLista) Inzynierka1Entities.ENTITY.ListaGraczy.DeleteObject(usuwanaLista);
                Inzynierka1Entities.ENTITY.SaveChanges();
            }
            catch (Exception exc)
            {
                success = false;
                System.Windows.Forms.MessageBox.Show(exc.Message);
            }

            return success;
        }


        public static bool CzyKlasyfikacje(int id_Zawodnika)
        {
            return (from Klasyfikacje szukanaKlasyfikacja in Inzynierka1Entities.ENTITY.Klasyfikacje
                    where szukanaKlasyfikacja.ID_Zawodnika == id_Zawodnika
                    select szukanaKlasyfikacja).Any();
        }

        public static IEnumerable<Klasyfikacje> ZwrocKlasyfikacjeZawodnika(int id_Zawodnika)
        {
            return (from Klasyfikacje KlasyfikacjeZawodnika in Inzynierka1Entities.ENTITY.Klasyfikacje
                    where KlasyfikacjeZawodnika.ID_Zawodnika == id_Zawodnika
                    select KlasyfikacjeZawodnika);
        }






        public static bool UsunKlasyfikacjeZawodnika(IEnumerable<Klasyfikacje> zwroconaKlasyfikacje)
        {
            bool success = true;
            try
            {
                foreach (Klasyfikacje usuwanaKlasyfikacje in zwroconaKlasyfikacje) Inzynierka1Entities.ENTITY.Klasyfikacje.DeleteObject(usuwanaKlasyfikacje);
                Inzynierka1Entities.ENTITY.SaveChanges();
            }
            catch (Exception exc)
            {
                success = false;
                System.Windows.Forms.MessageBox.Show(exc.Message);
            }

            return success;
        }

    }
}
