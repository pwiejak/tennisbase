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
    public partial class ZaplanowaneMeczeForm : Form
    {
        int aktualnaKomorka;

        public ZaplanowaneMeczeForm()
        {
            InitializeComponent();
            TabTurnieje.WczytajTurniej(rDDLTurniej);
            rbtUsunMecz.Enabled = false;
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

        private void rgvZaplanowaneMecze_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            aktualnaKomorka = int.Parse(rgvZaplanowaneMecze.Rows[e.RowIndex].Cells[0].Value.ToString());
            rbtUsunMecz.Enabled = true;
        }

        private void rDDLTurniej_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            int m_id = Convert.ToInt32(rDDLTurniej.SelectedValue);
            ZwrocMecze(m_id, rgvZaplanowaneMecze);
            rbtUsunMecz.Enabled = false;

        }

        private void rbtUsunMecz_Click(object sender, EventArgs e)
        {
            KortyTenisowe.UsunForm Usun = new KortyTenisowe.UsunForm(aktualnaKomorka, 3);
            Usun.Activate();
            Usun.ShowDialog();
            int m_id = Convert.ToInt32(rDDLTurniej.SelectedValue);
            ZwrocMecze(m_id, rgvZaplanowaneMecze);
            rbtUsunMecz.Enabled = false;
        }
    }
}
