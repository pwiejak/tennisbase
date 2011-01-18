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
            rbtUsunZawZTurnieju.Enabled = false;
        }

        public static void ZwrocZawodnikow(int idTurnieju, Telerik.WinControls.UI.RadGridView dataGrid)
        {
            List<ListaGraczy> m_Zawodnicy = new List<ListaGraczy>(); 
            int m_indeks = idTurnieju;
            if (m_Zawodnicy != null)
            {
                m_Zawodnicy = DBQueries.ZwrocZawodnikow(m_indeks).ToList<ListaGraczy>();
                dataGrid.Rows.Clear();
                for (int i = 0; i < m_Zawodnicy.Count; i++)
                {
                    dataGrid.Rows.Add(m_Zawodnicy[i].ID_Zawodnika, m_Zawodnicy[i].Zawodnicy.Imie, m_Zawodnicy[i].Zawodnicy.Nazwisko, m_Zawodnicy[i].Zawodnicy.Telefon);
                }
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
            if (e.RowIndex == -1) aktualnaKomorka = 0;
            else
            {
                aktualnaKomorka = int.Parse(rgvZawodnicy.Rows[e.RowIndex].Cells[0].Value.ToString());
                rbtEdytujZawodnika.Enabled = true;
                rbtUsunZawodnika.Enabled = true;
                rbtUsunZawZTurnieju.Enabled = true;
            }
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

        private void rbtDodajZawDoTurnieju_Click(object sender, EventArgs e)
        {
            KortyTenisowe.DodajZawodnikaDoTurniejuForm DodajZawodnikaDoTurnieju = new KortyTenisowe.DodajZawodnikaDoTurniejuForm();
            DodajZawodnikaDoTurnieju.Activate();
            DodajZawodnikaDoTurnieju.ShowDialog();

        }

        private void rbtUsunZawZTurnieju_Click(object sender, EventArgs e)
        {
            int m_id, m_idtur, m_idzaw;
            ListaGraczy m_lista;
            m_idtur = Convert.ToInt32(rDDLWybierzTurniej.SelectedValue);
            m_idzaw = aktualnaKomorka;
            m_lista = DBQueries.ZwrocKonkretnaLista(m_idtur, m_idzaw);
            m_id = DBQueries.ZwrocIDListy(m_lista);
            KortyTenisowe.UsunForm UsunZawZTurnieju = new KortyTenisowe.UsunForm(m_id, 4);
            UsunZawZTurnieju.Activate();
            UsunZawZTurnieju.ShowDialog();
            rgvZawodnicy.Rows.Clear();
            rDDLWybierzTurniej.SelectedIndex = -1;
            rbtUsunZawZTurnieju.Enabled = false;

            
        }
    }
}
