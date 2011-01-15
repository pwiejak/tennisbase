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
    public partial class EdytujTurniejForm : Form
    {
        int m_id; 

        public EdytujTurniejForm (Turnieje edytowanyTurniej)
        {
            int idtur;
            InitializeComponent();
            m_id = edytowanyTurniej.ID_Turnieju;
            this.rtbNazwa.Text = edytowanyTurniej.Nazwa;
            this.rtbOpis.Text = edytowanyTurniej.Opis;

            switch (edytowanyTurniej.Kategoria)
            {
                case 1:
                    rrbKategoriaM.IsChecked = true;
                    break;
                case 2:
                    rrbKategoriaK.IsChecked = true;
                    break;
                case 3:
                    rrbKategoriaJ.IsChecked = true;
                    break;
             }

            this.rDTPDataRozp.Value = edytowanyTurniej.DataRozp;
            this.rDTPDataZak.Value = edytowanyTurniej.DataZak;

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

            if (DBQueries.EdytujTurniej(m_id, Kategoria, DataRozpoczecia, DataZakonczenia, Nazwa,  Opis) == true)
            {
                MessageBox.Show("Edytowano poprawnie");
                this.Dispose();
            }
            else
            {
            System.Windows.Forms.MessageBox.Show("Wystąpił błąd.");
            }
                      
        }
    }
}
