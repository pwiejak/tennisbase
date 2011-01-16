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
        public WynikiForm()
        {
            InitializeComponent();
        }

        private void rbtDodajWynik_Click(object sender, EventArgs e)
        {
            KortyTenisowe.WyborMeczuForm WybierzMecz = new KortyTenisowe.WyborMeczuForm();
            WybierzMecz.Activate();
            WybierzMecz.ShowDialog();
        }

        private void rbtUsunWynik_Click(object sender, EventArgs e)
        {
            //KortyTenisowe.UsunForm Usun = new KortyTenisowe.UsunForm(aktualnaKomorka);
            //Usun.Activate();
            //Usun.ShowDialog();
        }
    }
}
