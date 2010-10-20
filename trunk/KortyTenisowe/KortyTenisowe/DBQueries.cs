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
                                     select pracownicy).LastOrDefault();
                
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
    }
}
