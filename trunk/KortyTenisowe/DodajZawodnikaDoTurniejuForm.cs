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
    public partial class DodajZawodnikaDoTurniejuForm : Form
    {
        public DodajZawodnikaDoTurniejuForm()
        {
            InitializeComponent();
            TabTurnieje.WczytajTurniej(rDDLTurniej);
            TabTurnieje.WczytajWszystkichZawodnikow(rDDLZawodnik);
        }

        private void rbtAnuluj_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void rbtOK_Click(object sender, EventArgs e)
       {

           int idturnieju = Convert.ToInt32(rDDLTurniej.SelectedValue);
           int idzawodnika = Convert.ToInt32(rDDLZawodnik.SelectedValue);


           if (DBQueries.CzyJuzGra(idturnieju, idzawodnika) == false)
           {
               if (DBQueries.DodajZawodnikaDoTurnieju(idturnieju, idzawodnika) == true)
               {
                   MessageBox.Show("Dodano poprawnie");
                   this.Dispose();
               }
               else
               {
                   System.Windows.Forms.MessageBox.Show("Wystąpił błąd.");
               }
           }
           else
           {
               System.Windows.Forms.MessageBox.Show("Ten gracz już uczestniczy w tym turnieju");
           }

       }
    }
}
