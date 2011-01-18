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


    public partial class WynikiForm : Form
    {
        int aktualnaKomorka;

        public WynikiForm()
        {
            InitializeComponent();
            rbtEdytujWynik.Enabled = false;
            rbtUsunWynik.Enabled = false;
            WczytajTurniej(rDDLWybierzTurniej);
            
        }


        public static void wypiszRozegrane(int id, Telerik.WinControls.UI.RadGridView dataGrid)
        {

            List<Mecze> rozegranyMecz = DBQueries.zwrocRozegrane(id).ToList();
            dataGrid.Rows.Clear();
            for (int i = 0; i < rozegranyMecz.Count; i++)
            {
                dataGrid.Rows.Add(rozegranyMecz[i].ID_Meczu, rozegranyMecz[i].Zawodnicy.Nazwisko + ", " + rozegranyMecz[i].Zawodnicy.Imie, "vs", rozegranyMecz[i].Zawodnicy1.Nazwisko + ", " + rozegranyMecz[i].Zawodnicy1.Imie, rozegranyMecz[i].Set1, rozegranyMecz[i].Set2, rozegranyMecz[i].Set3, rozegranyMecz[i].Set4, rozegranyMecz[i].Set5);
            }

        }

        public static void ZwrocMecze(int idTurnieju, Telerik.WinControls.UI.RadGridView dataGrid)
        {
            List<Mecze> m_Mecze = new List<Mecze>();
            int m_indeks = idTurnieju;
            m_Mecze = DBQueries.ZwrocZaplanowaneMecze(m_indeks).ToList<Mecze>();
            dataGrid.Rows.Clear();

            for (int i = 0; i < m_Mecze.Count; i++)
            {
                dataGrid.Rows.Add(m_Mecze[i].ID_Meczu, m_Mecze[i].Zawodnicy.Nazwisko + ", " + m_Mecze[i].Zawodnicy.Imie, "vs", m_Mecze[i].Zawodnicy1.Nazwisko + ", " + m_Mecze[i].Zawodnicy1.Imie);
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



        private void rbtDodajWynik_Click(object sender, EventArgs e)
        {
            KortyTenisowe.WyborMeczuForm WybierzMecz = new KortyTenisowe.WyborMeczuForm();
            WybierzMecz.Activate();
            WybierzMecz.ShowDialog();
        }

        private void rbtUsunWynik_Click(object sender, EventArgs e)
        {
            KortyTenisowe.UsunForm Usun = new KortyTenisowe.UsunForm(aktualnaKomorka, 7);
            Usun.Activate();
            Usun.ShowDialog();
            rbtEdytujWynik.Enabled = false;
            rbtUsunWynik.Enabled = false;
            wypiszRozegrane(Convert.ToInt32(rDDLWybierzTurniej.SelectedValue), rgvWyniki);
        }

        private void rDDLWybierzTurniej_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            wypiszRozegrane(Convert.ToInt32(rDDLWybierzTurniej.SelectedValue), rgvWyniki);
        }

        private void rgvWyniki_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) aktualnaKomorka = 0;
            else
            {
                aktualnaKomorka = int.Parse(rgvWyniki.Rows[e.RowIndex].Cells[0].Value.ToString());
                rbtEdytujWynik.Enabled = true;
                rbtUsunWynik.Enabled = true;
            }
        }

        private void rbtEdytujWynik_Click(object sender, EventArgs e)
        {

            Mecze edytowanyWynik = DBQueries.ZwrocKonkretnyMecz(aktualnaKomorka);
            new EdytujWynikForm(edytowanyWynik).ShowDialog();
            int m_id = Convert.ToInt32(rDDLWybierzTurniej.SelectedValue);
            ZwrocMecze(m_id, rgvWyniki);
            rbtEdytujWynik.Enabled = false;
            rbtUsunWynik.Enabled = false;
            wypiszRozegrane(Convert.ToInt32(rDDLWybierzTurniej.SelectedValue), rgvWyniki);
        }
    }
}
