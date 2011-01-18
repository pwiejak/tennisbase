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
    public partial class DodajZamowienieForm : Form
    {
        public DodajZamowienieForm()
        {
            InitializeComponent();
            TabSerwis.WczytajKlienta(rDDLKlient);
            TabSerwis.WczytajUsluge(rDDLUsluga);
            rDTPDataPrzyj.Value = DateTime.Now;
        }

        private void rbtAnuluj_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void rbtOK_Click(object sender, EventArgs e)
        {

            DateTime dataPocz = rDTPDataPrzyj.Value;
            int idkl = Convert.ToInt32(rDDLKlient.SelectedValue);
            int idus = Convert.ToInt32(rDDLUsluga.SelectedValue);

            if ((idkl == -1) || (idus == -1))
            {
                System.Windows.Forms.MessageBox.Show("Proszę wypełnić wszystkie pola.");
            }
            else
            {
                if (DBQueries.DodajZamowienie(dataPocz, idkl, idus) == true)
                {
                    MessageBox.Show("Dodano poprawnie");
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
