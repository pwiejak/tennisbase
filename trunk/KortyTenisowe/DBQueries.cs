﻿using System;
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
                System.Windows.Forms.MessageBox.Show("Błąd przy dodawaniu: "+ e.Message);
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

            return(from Rezerwacje_Kortow ZarezerwowaneKorty in KortyTenisowe.Inzynierka1Entities.ENTITY.Rezerwacje_Kortow
                      where ZarezerwowaneKorty.Data == data
                       select ZarezerwowaneKorty) ;
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
            if(data != null)
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
            dodawanySprzet.Typ = indeksTypu+1;
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
    }
}
