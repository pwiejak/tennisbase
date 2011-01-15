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
    public partial class DodajZawodnikaForm : Form
    {

        public DodajZawodnikaForm()
        {
            InitializeComponent();
            TabTurnieje.WczytajTurniej(rDDLTurniej);
        }

        private void rbtAnuluj_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void rDDLWybierzTurniej_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
           int pozycja = e.Position +1;
        }

        private void rbtOK_Click(object sender, EventArgs e)
        {
            if ((rtbNazwisko.Text == "") || (rtbImie.Text == "") || (rtbTelefon.Text == "") || (rtbEmail.Text == "") || (rDDLTurniej.SelectedIndex == -1))
                {
                    System.Windows.Forms.MessageBox.Show("Proszę wypełnić wszystkie pola");
                }
                else
                {
                    bool phoneValid = true;
                    string Telefon = rtbTelefon.Text;
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
                        string nazwisko = rtbNazwisko.Text;
                        string imie = rtbImie.Text;
                        string telefon = rtbTelefon.Text;
                        string email = rtbEmail.Text;
                        int idturnieju = rDDLTurniej.SelectedIndex +1;

                            if (DBQueries.DodajZawodnika(imie, nazwisko, telefon, email, idturnieju) == true)
                            {
                                MessageBox.Show("Dodano poprawnie");
                                this.Dispose();
                            }
                            else
                                System.Windows.Forms.MessageBox.Show("Wystąpił błąd.");
                       

                    }
                }
        }

    }
}