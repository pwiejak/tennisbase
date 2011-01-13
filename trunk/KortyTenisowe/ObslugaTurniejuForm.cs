using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KortyTenisowe
{
    public partial class ObslugaTurniejuForm : Form
    {
        int aktualnaKomorka;

        public ObslugaTurniejuForm()
        {
            InitializeComponent();
            WczytajTurniej(rDDLWybierzTurniej);
        }

        public static void ZwrocZawodnikow(int idTurnieju, Telerik.WinControls.UI.RadGridView dataGrid)
        {
            List<Zawodnicy> m_Zawodnicy = new List<Zawodnicy>(); 
            int m_indeks = idTurnieju;
            m_Zawodnicy = DBQueries.ZwrocZawodnikow(m_indeks).ToList<Zawodnicy>();
            dataGrid.Rows.Clear();
            
            for (int i = 0; i < m_Zawodnicy.Count; i++)
            {
                dataGrid.Rows.Add(m_Zawodnicy[i].ID_Zawodnika, m_Zawodnicy[i].Imie, m_Zawodnicy[i].Nazwisko, m_Zawodnicy[i].Telefon);
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
                listaTurniejow.Items.Add(element);
            }
        }

        private void rDDLWybierzTurniej_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            ZwrocZawodnikow(e.Position + 1, rgvZawodnicy);
        }

        private void rbtDodajZawodnika_Click(object sender, EventArgs e)
        {
            KortyTenisowe.DodajZawodnikaForm DodajZawodnika = new KortyTenisowe.DodajZawodnikaForm();
            DodajZawodnika.Activate();
            DodajZawodnika.ShowDialog();
            //ZwrocZawodnikow(8,rgvZawodnicy);
        }

        private void rbtZaplanujMecz_Click(object sender, EventArgs e)
        {
            KortyTenisowe.ZaplanujMeczForm ZaplanujMecz = new KortyTenisowe.ZaplanujMeczForm();
            ZaplanujMecz.Activate();
            ZaplanujMecz.ShowDialog();
        }

        private void rbtUsunZawodnika_Click(object sender, EventArgs e)
        {
            KortyTenisowe.UsunForm Usun = new KortyTenisowe.UsunForm(aktualnaKomorka, 1);
            Usun.Activate();
            Usun.ShowDialog();
            //ZwrocZawodnikow(8,rgvZawodnicy);
        }

        private void rgvZawodnicy_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            //rbDodajNaMagazyn.Enabled = true;
            aktualnaKomorka = int.Parse(rgvZawodnicy.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        //public static void PokazZawodnikow(int ID_Zawodnika, Telerik.WinControls.UI.RadGridView dataGrid)
        //{
        //    List<Zawodnicy> m_lista = new List<Zawodnicy>();
        //    int m_indeks = ID_Zawodnika;
        //    m_lista = DBQueries.zwrocZawodnikow(m_indeks).ToList<Zawodnicy>();
        //    dataGrid.Rows.Clear();

        //    for (int i = 0; i < m_lista.Count; i++)
        //    {
        //        dataGrid.Rows.Add(m_lista[i].ID, m_lista[i].Imie, m_lista[i].Nazwisko, m_lista[i].Telefon);
        //        //dataGrid.Rows[i].Cells[1].Value = i;
        //        //dataGrid.Rows[i+1].Cells[1].Value = m_lista[i].Marka;
        //    }
        //}
    }
}
