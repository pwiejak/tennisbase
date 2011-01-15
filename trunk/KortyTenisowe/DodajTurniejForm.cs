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
    public partial class DodajTurniejForm : Form
    {
        public DodajTurniejForm()
        {
            InitializeComponent();
            this.rDTPDataRozp.Value = DateTime.Now;
            this.rDTPDataZak.Value = DateTime.Now;
        }

        private void rbtAnuluj_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void rbtOK_Click(object sender, EventArgs e)
        {
            int Kategoria = 0;
            
            if (rrbKategoriaM.IsChecked) Kategoria = 1;
            if (rrbKategoriaK.IsChecked) Kategoria = 2;
            if (rrbKategoriaJ.IsChecked) Kategoria = 3;


            string Nazwa = rtbNazwa.Text;
            string Opis = rtbOpis.Text;
            DateTime DataRozpoczecia = rDTPDataRozp.Value;
            DateTime DataZakonczenia = rDTPDataZak.Value;

            if (DBQueries.DodajTurniej(Kategoria, DataRozpoczecia, DataZakonczenia, Nazwa,  Opis) == true)
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
