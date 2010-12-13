using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace KortyTenisowe
{
    class TabKorty
    {
        public List<Rezerwacje_Kortow> PobierzRezerwacje(DateTime data)
        {
            List<Rezerwacje_Kortow> kortyLista = new List<Rezerwacje_Kortow>();
            IEnumerable<Rezerwacje_Kortow> korty = DBQueries.ZwrocRezerwacjeKortowWgDaty(data);
            kortyLista = korty.ToList();
            int dzienTygodnia = dzienTygodnia = zwrocNrDniaTygodnia(data);
            /*
            DayOfWeek wybranyDzien = data.DayOfWeek;
            
            switch (wybranyDzien)
            {
                case DayOfWeek.Monday:
                    dzienTygodnia = 1;
                    break;
                case DayOfWeek.Tuesday:
                    dzienTygodnia = 2;
                    break;
                case DayOfWeek.Wednesday:
                    dzienTygodnia = 3;
                    break;
                case DayOfWeek.Thursday:
                    dzienTygodnia = 4;
                    break;
                case DayOfWeek.Friday:
                    dzienTygodnia = 5;
                    break;
                case DayOfWeek.Saturday:
                    dzienTygodnia = 6;
                    break;
                case DayOfWeek.Sunday:
                    dzienTygodnia = 7;
                    break;
            }
            */
            korty = DBQueries.ZwrocRezerwacjeKortowWgDnia(dzienTygodnia);
            List<Rezerwacje_Kortow> kortyLista1 = new List<Rezerwacje_Kortow>();
            kortyLista1 = korty.ToList();

            for (int i = 0; i < korty.Count(); i++)
            {
                kortyLista.Add(kortyLista1[i]);
            }

            return kortyLista;
        }

        public static void OdswiezKorty(List<Rezerwacje_Kortow> kortyDoWyswietlenia)
        {
            for (int kolejnyKort = 1; kolejnyKort < 5; kolejnyKort++)
            {
                for (int iloscRezerwacji = 0; iloscRezerwacji < kortyDoWyswietlenia.Count; iloscRezerwacji++)
                {
                    if (kortyDoWyswietlenia[iloscRezerwacji].Nr_Kortu == kolejnyKort)
                    {
                        WyswietlGodziny(kolejnyKort, kortyDoWyswietlenia[iloscRezerwacji]);    
                    }
                }
            }
        }

        public static void WyswietlGodziny(int ktoryKort, Rezerwacje_Kortow wyswietlanyKort)
        {
            int godzinaRozpoczecia = wyswietlanyKort.Godz_Rozpoczecia;
            
        }

        public void WyswietlAktualnaRezerwacjeJednorazowa(System.Windows.Forms.DataGridView korty,
                                                System.Windows.Forms.DataGridViewCellEventArgs e,
                                                 System.Windows.Forms.RichTextBox rtbInformacja,
                                                  DateTime aktualnaData)
        {
            int godzinaRezerwacji, nrKortu;
            godzinaRezerwacji = e.RowIndex + 6;
            int temp = 1;
            while (true)
            {
                if ((korty.Rows[e.RowIndex - temp].Cells[e.ColumnIndex].Style.BackColor) == Color.Crimson)
                {
                    godzinaRezerwacji--;
                    temp++;
                }
                else
                {
                    break;
                }
            }
            nrKortu = e.ColumnIndex;
            Rezerwacje_Kortow znalezionaRezerwacja = new Rezerwacje_Kortow();
            List<Rezerwacje_Kortow> rezerwacje = DBQueries.ZwrocRezerwacjeKortowWgDaty(aktualnaData).ToList<Rezerwacje_Kortow>();
            foreach (Rezerwacje_Kortow szukanaRezrwacja in rezerwacje)
            {
                if ((szukanaRezrwacja.Godz_Rozpoczecia == godzinaRezerwacji) && (szukanaRezrwacja.Nr_Kortu == nrKortu))
                {
                    znalezionaRezerwacja = szukanaRezrwacja;
                }
            }

            Uzytkownicy_Kortow klient = new Uzytkownicy_Kortow();
            klient = DBQueries.zwrocKonkretnegoKLienta(znalezionaRezerwacja.ID_Osoby);
            rtbInformacja.Text = "";
            rtbInformacja.Text += klient.Imię + " " + klient.Nazwisko + ", tel. " +
                                    klient.Telefon;

        }

        public void WyswietlAktualnaRezerwacjeStala(System.Windows.Forms.DataGridView korty,
                                                System.Windows.Forms.DataGridViewCellEventArgs e,
                                                 System.Windows.Forms.RichTextBox rtbInformacja,
                                                  DateTime aktualnaData)
        {
            int godzinaRezerwacji, nrKortu;
            godzinaRezerwacji = e.RowIndex + 6;
            int temp = 1;
            while (true)
            {
                if ((korty.Rows[e.RowIndex - temp].Cells[e.ColumnIndex].Style.BackColor) == Color.Black)
                {
                    godzinaRezerwacji--;
                    temp++;
                }
                else
                {
                    break;
                }
            }
            nrKortu = e.ColumnIndex;
            Rezerwacje_Kortow znalezionaRezerwacja = new Rezerwacje_Kortow();
            List<Rezerwacje_Kortow> rezerwacje = DBQueries.ZwrocRezerwacjeKortowWgDnia(zwrocNrDniaTygodnia(aktualnaData)).ToList<Rezerwacje_Kortow>();
            foreach (Rezerwacje_Kortow szukanaRezrwacja in rezerwacje)
            {
                if ((szukanaRezrwacja.Godz_Rozpoczecia == godzinaRezerwacji) && (szukanaRezrwacja.Nr_Kortu == nrKortu))
                {
                    znalezionaRezerwacja = szukanaRezrwacja;
                }
            }

            Uzytkownicy_Kortow klient = new Uzytkownicy_Kortow();
            klient = DBQueries.zwrocKonkretnegoKLienta(znalezionaRezerwacja.ID_Osoby);
            rtbInformacja.Text = "";
            rtbInformacja.Text += klient.Imię + " " + klient.Nazwisko + ", tel. " +
                                    klient.Telefon;

        }

        private int zwrocNrDniaTygodnia(DateTime data)
        {

            DayOfWeek wybranyDzien = data.DayOfWeek;
            switch (wybranyDzien)
            {
                case DayOfWeek.Monday:
                    return 1;
                    break;
                case DayOfWeek.Tuesday:
                    return 2;
                    break;
                case DayOfWeek.Wednesday:
                    return 3;
                    break;
                case DayOfWeek.Thursday:
                    return 4;
                    break;
                case DayOfWeek.Friday:
                    return 5;
                    break;
                case DayOfWeek.Saturday:
                    return 6;
                    break;
                case DayOfWeek.Sunday:
                    return 7;
                    break;
                default:
                    return 0;
            }
        }
    }
}
