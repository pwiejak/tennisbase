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
    public partial class DodajKlientaForm : Form
    {
        public DodajKlientaForm()
        {
            InitializeComponent();
        }

        private void btDodaj_Click(object sender, EventArgs e)
        {
            if ((tbNazwisko.Text == "") || (tbImie.Text == "") || (tbTelefon.Text == ""))
            {
                System.Windows.Forms.MessageBox.Show("Proszę wypełnić wszystkie pola");
            }
            else
            {
                bool phoneValid = true;
                string Telefon = tbTelefon.Text;
                for (int i = 0; i < Telefon.Length; i++)
                {
                    if ((byte)Telefon[i] < 48 || (byte)Telefon[i] > 57)
                    {
                        phoneValid = false;
                        System.Windows.Forms.MessageBox.Show("Zly numer telefonu");
                    }
                    if (phoneValid == false)
                        break;
                }
                if (phoneValid)
                {
                    string nazwisko = tbNazwisko.Text;
                    string imie = tbImie.Text;
                    string telefon = tbTelefon.Text;
                    int typKlienta;
                    if (rbUzytkownik.Checked == true)
                    {
                        typKlienta = 1;
                    }
                    else typKlienta = 2;
                    if(DBQueries.DodajKlienta(imie, nazwisko, telefon, typKlienta) == true)
                    {
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
}
