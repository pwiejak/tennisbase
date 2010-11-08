using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KortyTenisowe
{
    class TabKorty
    {
        public static List<Rezerwacje_Kortow> PobierzRezerwacje(DateTime data)
        {
            List<Rezerwacje_Kortow> kortyLista = new List<Rezerwacje_Kortow>();
            IEnumerable<Rezerwacje_Kortow> korty = DBQueries.ZwrocRezerwacjeKortowWgDaty(data);
            kortyLista = korty.ToList();
            DayOfWeek wybranyDzien = data.DayOfWeek;
            int dzienTygodnia=0;
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
    }
}
