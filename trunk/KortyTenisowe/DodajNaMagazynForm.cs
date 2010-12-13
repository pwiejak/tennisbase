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
    public partial class DodajNaMagazynForm : Telerik.WinControls.UI.RadForm
    {
        int idPrzedmiotu;
        public DodajNaMagazynForm(int id)
        {
            idPrzedmiotu = id;
            InitializeComponent();
        }

        private void rbtDodaj_Click(object sender, EventArgs e)
        {
            int iloscSztuk=0, typSprzedazy = 1;
            string rozmiar = "";
            string kolor = "";
            float cena = 0;
            bool success = true;
            if (rtbIloscSztuk.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Podaj iloœæ sztuk");
            }
            else
                if( (rbSprzedaz.IsChecked == false) && (rbWypozyczenie.IsChecked == false)  )
                {
                    System.Windows.Forms.MessageBox.Show("Wybierz rodzaj sprzeda¿y");
                }
            else
            {
                try
                {
                    iloscSztuk = int.Parse(rtbIloscSztuk.Text);
                    if (rbSprzedaz.IsChecked == true)
                        typSprzedazy = 1;
                    else
                        typSprzedazy = 2;
                    rozmiar = rtbRozmiar.Text;
                    kolor = rtbKolor.Text;
                    cena = float.Parse(rtbCena.Text);
                }
                catch (Exception exc)
                {
                    System.Windows.Forms.MessageBox.Show("Error: " + exc.Message);
                    success = false;
                }

                if (success)
                {
                    if (DBQueries.dodajSprzetNaMagazyn(idPrzedmiotu, typSprzedazy, iloscSztuk, rozmiar, kolor, cena))
                    {
                        System.Windows.Forms.MessageBox.Show("Dodano");
                        this.Dispose();
                    }                    
                }
            }
            
        }
    }
}
