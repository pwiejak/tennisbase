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

    public partial class UsunForm : Telerik.WinControls.UI.RadForm
    {
        int m_id, m_nad;        

        public UsunForm(int id, int nad)
        {
            InitializeComponent();
            m_id = id;
            m_nad = nad;
        }

        private void rbtNie_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void rbtTak_Click(object sender, EventArgs e)
        {

            switch (m_nad)
            {
                case 1:
                    DBQueries.UsunZawodnika(m_id);
                    break;
                case 2:
                    DBQueries.UsunTurniej(m_id);
                    break;
                case 3:
                    DBQueries.UsunMecz(m_id);
                    break;
                default:
                    break;
            }

                System.Windows.Forms.MessageBox.Show("Usunięto.");
                this.Dispose();

        }
    }
}
