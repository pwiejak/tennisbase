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

    public partial class ZmienStanZamowieniaForm : Form
    {
        int m_stan, m_id;
        public ZmienStanZamowieniaForm(int idzam, int stan)
        {
            int m_stan;
            InitializeComponent();
            TabSerwis.WczytajStan(rDDLStan);
            rDDLStan.SelectedValue = stan;
            m_id = idzam;
            m_stan = stan;

        }

        private void rbtAnuluj_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void rbtOK_Click(object sender, EventArgs e)
        {
            if (m_stan == Convert.ToInt32(rDDLStan.SelectedValue))
            {
                System.Windows.Forms.MessageBox.Show("Status nie został zmieniony.");

            }
            else 
            {
                if (DBQueries.ZmienStatus(m_id,Convert.ToInt32(rDDLStan.SelectedValue)) == true)
                {
                    MessageBox.Show("Zmieniono status");
                    this.Dispose();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Wystąpił błąd.");
                }
            }
        }
    }
    
}
