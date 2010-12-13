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
    public partial class ZmienIloscForm : Telerik.WinControls.UI.RadForm
    {
        int m_id, m_ilosc;

        public ZmienIloscForm(int id)
        {
            InitializeComponent();
            m_id = id;
            m_ilosc = DBQueries.zwrocIloscStanuMagazynu(m_id);
            rlblAktualnaIlosc.Text += m_ilosc.ToString();
        }

        private void rbtOK_Click(object sender, EventArgs e)
        {
            int nowaIlosc;
            if(int.TryParse(rtbIlosc.Text, out nowaIlosc))
            {
                if (DBQueries.zmienIloscStanuMagazynowego(m_id, nowaIlosc))
                {
                    System.Windows.Forms.MessageBox.Show("Zmieniono iloœæ.");
                    this.Dispose();
                }
            }
        }
    }
}
