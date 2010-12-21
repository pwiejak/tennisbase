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
        public ObslugaTurniejuForm()
        {
            InitializeComponent();
        }

        private void rbtDodajZawodnika_Click(object sender, EventArgs e)
        {
            KortyTenisowe.DodajZawodnikaForm DodajZawodnika = new KortyTenisowe.DodajZawodnikaForm();
            DodajZawodnika.Activate();
            DodajZawodnika.ShowDialog();
        }

        private void rbtZaplanujMecz_Click(object sender, EventArgs e)
        {
            KortyTenisowe.ZaplanujMeczForm ZaplanujMecz = new KortyTenisowe.ZaplanujMeczForm();
            ZaplanujMecz.Activate();
            ZaplanujMecz.ShowDialog();
        }

        private void rbtUsunZawodnika_Click(object sender, EventArgs e)
        {
            KortyTenisowe.UsunForm Usun = new KortyTenisowe.UsunForm();
            Usun.Activate();
            Usun.ShowDialog();
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
