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
        }

        private void rbtAnuluj_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //private void rbtOK_Click(object sender, EventArgs e)
        //{
        //   /*if ((rtbNazwisko.Text == "") || (rtbImie.Text == "") || (rtbTelefon.Text == ""))
        //    {
        //        System.Windows.Forms.MessageBox.Show("Proszę wypełnić wszystkie pola");
        //    }
        //    else
        //    {
        //        bool phoneValid = true;
        //        string Telefon = rtbTelefon.Text;
        //        for (int i = 0; i < Telefon.Length; i++)
        //        {
        //            if ((byte)Telefon[i] < 48 || (byte)Telefon[i] > 57)
        //            {
        //                phoneValid = false;
        //                System.Windows.Forms.MessageBox.Show("Zly numer telefonu");
        //            }
        //            if (phoneValid == false)
        //                break;
        //        }
        //        if (phoneValid)
        //        {*/
        //            string nazwisko = rtbNazwisko.Text;
        //            string imie = rtbImie.Text;
        //            string telefon = rtbTelefon.Text;
        //            string email = rtbEmail.Text;
        //            /*if (rbUzytkownik.Checked == true)
        //            {
        //                typKlienta = 1;
        //            }
        //            else typKlienta = 2;*/
        //            if (DBQueries.DodajZawodnika(imie, nazwisko, telefon, email) == true)
        //            {
        //                MessageBox.Show("Dodano poprawnie");
        //                this.Dispose();
        //            }
        //            else
        //            {
        //                System.Windows.Forms.MessageBox.Show("Wystąpił błąd.");
        //            }


        //             }
        //         }
        //     }
        //}
    }
}