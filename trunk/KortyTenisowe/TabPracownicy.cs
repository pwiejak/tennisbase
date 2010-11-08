using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KortyTenisowe
{
    class TabPracownicy
    {
        public static void Dodaj(string Imie, string Nazwisko, string Telefon, string Login, int Uprawnienie, string Haslo)
        {
            DBQueries.DodajPracownika(Imie, Nazwisko, Telefon, Login, Uprawnienie, Haslo);
        }
    }
}
