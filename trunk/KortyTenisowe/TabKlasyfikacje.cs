using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KortyTenisowe
{
    class TabKlasyfikacje
    {
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

        public static void WypiszKlasyfikacjeTurnieju(int idtur, Telerik.WinControls.UI.RadGridView dataGrid)
        {
            
            List<Klasyfikacje> KlasyfikacjeTurnieju = DBQueries.ZwrocKlasyfikacjeTurnieju(idtur).ToList();
            dataGrid.Rows.Clear();
            for (int i = 0; i < KlasyfikacjeTurnieju.Count; i++)
            {
                dataGrid.Rows.Add(KlasyfikacjeTurnieju[i].ID_Klasyfikacji, KlasyfikacjeTurnieju[i].Miejsce, KlasyfikacjeTurnieju[i].Zawodnicy.Imie, KlasyfikacjeTurnieju[i].Zawodnicy.Nazwisko, KlasyfikacjeTurnieju[i].Punkty);
            }
        }

        public static void WypiszGeneralna(Telerik.WinControls.UI.RadGridView dataGrid)
        {

            List<Generalna> KlasyfikacjaGeneralna = DBQueries.ZwrocGeneralna().ToList();
            dataGrid.Rows.Clear();
            for (int i = 0; i < KlasyfikacjaGeneralna.Count; i++)
            {
                dataGrid.Rows.Add(KlasyfikacjaGeneralna[i].ID_Zawodnika, i + 1, KlasyfikacjaGeneralna[i].Zawodnicy.Imie, KlasyfikacjaGeneralna[i].Zawodnicy.Nazwisko, KlasyfikacjaGeneralna[i].Punkty);
            }
        }
    }
}
