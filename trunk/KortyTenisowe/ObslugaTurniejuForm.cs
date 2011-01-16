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
            TabTurnieje.WczytajTurniej(rDDLWybierzTurniej);
            rbtEdytujZawodnika.Enabled = false;
            rbtUsunZawodnika.Enabled = false;
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


        private void rDDLWybierzTurniej_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            int  m_id = Convert.ToInt32(rDDLWybierzTurniej.SelectedValue);
            ZwrocZawodnikow(m_id, rgvZawodnicy);
            rbtEdytujZawodnika.Enabled = false;
            rbtUsunZawodnika.Enabled = false;

        }

        private void rbtDodajZawodnika_Click(object sender, EventArgs e)
        {
            KortyTenisowe.DodajZawodnikaForm DodajZawodnika = new KortyTenisowe.DodajZawodnikaForm();
            DodajZawodnika.Activate();
            DodajZawodnika.ShowDialog();
            int m_id = Convert.ToInt32(rDDLWybierzTurniej.SelectedValue);
            ZwrocZawodnikow(m_id, rgvZawodnicy);
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
            int m_id = Convert.ToInt32(rDDLWybierzTurniej.SelectedValue);
            ZwrocZawodnikow(m_id, rgvZawodnicy);
            rbtEdytujZawodnika.Enabled = false;
            rbtUsunZawodnika.Enabled = false;
        }

        private void rgvZawodnicy_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            aktualnaKomorka = int.Parse(rgvZawodnicy.Rows[e.RowIndex].Cells[0].Value.ToString());
            rbtEdytujZawodnika.Enabled = true;
            rbtUsunZawodnika.Enabled = true;
        }

        private void rbtEdytujZawodnika_Click(object sender, EventArgs e)
        {

            Zawodnicy edytowanyZawodnik = DBQueries.ZwrocKonkretnegoZawodnika(aktualnaKomorka);
            new EdytujZawodnikaForm(edytowanyZawodnik).ShowDialog();
            int m_id = Convert.ToInt32(rDDLWybierzTurniej.SelectedValue);
            ZwrocZawodnikow(m_id, rgvZawodnicy);
            rbtEdytujZawodnika.Enabled = false;
            rbtUsunZawodnika.Enabled = false;
                        
        }

        private void rbtZaplanowaneMecze_Click(object sender, EventArgs e)
        {
            KortyTenisowe.ZaplanowaneMeczeForm ZaplanowaneMecze = new KortyTenisowe.ZaplanowaneMeczeForm();
            ZaplanowaneMecze.Activate();
            ZaplanowaneMecze.ShowDialog();
        }
    }
}
