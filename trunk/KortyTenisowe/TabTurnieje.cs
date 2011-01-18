using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KortyTenisowe
{
    class TabTurnieje
    {
        public static void ZwrocTurnieje(Telerik.WinControls.UI.RadGridView dataGrid)
        {
            List<Turnieje> WszystkieTurnieje = DBQueries.ZwrocTurnieje().ToList();
            
            dataGrid.Rows.Clear();
            for (int i = 0; i < WszystkieTurnieje.Count; i++)
            {
                dataGrid.Rows.Add(WszystkieTurnieje[i].ID_Turnieju, WszystkieTurnieje[i].Nazwa, WszystkieTurnieje[i].Opis, WszystkieTurnieje[i].Kategorie.Nazwa);
            }
        }

        public static void WczytajTurniej(Telerik.WinControls.UI.RadDropDownList listaTurniejow)
        {
            List<Turnieje> WszystkieTurnieje = DBQueries.ZwrocTurnieje().ToList();
            listaTurniejow.Items.Clear();

            for (int i = 0; i < WszystkieTurnieje.Count; i++)
            {
                Telerik.WinControls.UI.RadListDataItem element = new Telerik.WinControls.UI.RadListDataItem();
                element.Text = WszystkieTurnieje[i].Nazwa;
                element.Value = WszystkieTurnieje[i].ID_Turnieju;
                listaTurniejow.Items.Add(element);
            }
        }

        public static void WczytajZawodnika(int id, Telerik.WinControls.UI.RadDropDownList listaZawodnikow)
        {
            List<ListaGraczy> ZawodnicyTurnieju = DBQueries.ZwrocZawodnikow(id).ToList();
            listaZawodnikow.Items.Clear();

            for (int i = 0; i < ZawodnicyTurnieju.Count; i++)
            {
                Telerik.WinControls.UI.RadListDataItem element = new Telerik.WinControls.UI.RadListDataItem();
                element.Text = ZawodnicyTurnieju[i].Zawodnicy.Nazwisko + ", " + ZawodnicyTurnieju[i].Zawodnicy.Imie;
                element.Value = ZawodnicyTurnieju[i].ID_Zawodnika;
                listaZawodnikow.Items.Add(element);
            }
        }


        public static void WczytajWszystkichZawodnikow(Telerik.WinControls.UI.RadDropDownList listaZawodnikow)
        {
            List<Zawodnicy> ZawodnicyTurnieju = DBQueries.ZwrocWszystkichZawodnikow().ToList();
            listaZawodnikow.Items.Clear();

            for (int i = 0; i < ZawodnicyTurnieju.Count; i++)
            {
                Telerik.WinControls.UI.RadListDataItem element = new Telerik.WinControls.UI.RadListDataItem();
                element.Text = ZawodnicyTurnieju[i].Nazwisko + ", " + ZawodnicyTurnieju[i].Imie;
                element.Value = ZawodnicyTurnieju[i].ID_Zawodnika;
                listaZawodnikow.Items.Add(element);
            }
        }
    }
}
