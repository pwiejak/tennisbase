using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KortyTenisowe
{
    class TabSerwis
    {
        public static void WczytajKlienta(Telerik.WinControls.UI.RadDropDownList listaKlientow)
        {
            List<Uzytkownicy_Kortow> Klienci = DBQueries.ZwrocKlientow().ToList();
            listaKlientow.Items.Clear();

            for (int i = 0; i < Klienci.Count; i++)
            {
                Telerik.WinControls.UI.RadListDataItem element = new Telerik.WinControls.UI.RadListDataItem();
                element.Text = Klienci[i].Nazwisko + ", " + Klienci[i].Imię;
                element.Value = Klienci[i].ID;
                listaKlientow.Items.Add(element);
            }
        }


        public static void WczytajUsluge(Telerik.WinControls.UI.RadDropDownList listaUslug)
        {
            List<Katalog_Uslug> Uslugi = DBQueries.ZwrocUslugi().ToList();
            listaUslug.Items.Clear();

            for (int i = 0; i < Uslugi.Count; i++)
            {
                Telerik.WinControls.UI.RadListDataItem element = new Telerik.WinControls.UI.RadListDataItem();
                element.Text = Uslugi[i].Nazwa;
                element.Value = Uslugi[i].ID_Uslugi;
                listaUslug.Items.Add(element);
            }
        }


        public static void WczytajStan(Telerik.WinControls.UI.RadDropDownList listaUslug)
        {
            List<Stan_Uslug> Stany = DBQueries.ZwrocStany().ToList();
            listaUslug.Items.Clear();

            for (int i = 0; i < Stany.Count; i++)
            {
                Telerik.WinControls.UI.RadListDataItem element = new Telerik.WinControls.UI.RadListDataItem();
                element.Text = Stany[i].Nazwa;
                element.Value = Stany[i].ID_Stanu;
                listaUslug.Items.Add(element);
            }
        }

        public static void WypiszZamowienia(int id, Telerik.WinControls.UI.RadGridView dataGrid)
        {
            List<Serwis> Zamowienia = DBQueries.ZwrocZamowieniaWgUslugi(id).ToList();

            dataGrid.Rows.Clear();
            for (int i = 0; i < Zamowienia.Count; i++)
            {
                dataGrid.Rows.Add(Zamowienia[i].ID_Zlecenia, Zamowienia[i].Uzytkownicy_Kortow.Nazwisko + ", " + Zamowienia[i].Uzytkownicy_Kortow.Imię, Zamowienia[i].Katalog_Uslug.Nazwa, Zamowienia[i].Data_Przyjecia, Zamowienia[i].Stan_Uslug.Nazwa);
            }
        }

        public static void WypiszZamowieniaNieodebrane(int id, Telerik.WinControls.UI.RadGridView dataGrid)
        {
            List<Serwis> Zamowienia = DBQueries.ZwrocZamowieniaNieodebrane(id).ToList();

            dataGrid.Rows.Clear();
            for (int i = 0; i < Zamowienia.Count; i++)
            {
                dataGrid.Rows.Add(Zamowienia[i].ID_Zlecenia, Zamowienia[i].Uzytkownicy_Kortow.Nazwisko + ", " + Zamowienia[i].Uzytkownicy_Kortow.Imię, Zamowienia[i].Katalog_Uslug.Nazwa, Zamowienia[i].Data_Przyjecia, Zamowienia[i].Stan_Uslug.Nazwa);
            }
        }

    }
}
