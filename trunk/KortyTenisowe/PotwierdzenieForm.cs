using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace KortyTenisowe
{
    public partial class PotwierdzenieForm : Telerik.WinControls.UI.RadForm
    {
        int m_id;

        public PotwierdzenieForm(int id)
        {
            InitializeComponent();
            m_id = id;
        }

        private void rbtNie_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void rbtTak_Click(object sender, EventArgs e)
        {
            if (DBQueries.UsunPrzedmiotZMagazynu(m_id))
            {
                System.Windows.Forms.MessageBox.Show("Usuniêto.");
                this.Dispose();
            }
        }
    }
}
