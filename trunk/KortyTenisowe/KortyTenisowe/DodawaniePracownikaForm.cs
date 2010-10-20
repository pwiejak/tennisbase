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
    public partial class DodawaniePracownikaForm : Form
    {
        public DodawaniePracownikaForm()
        {
            InitializeComponent();
            this.rbUzytkownik.Checked = true;
        }

        private void bAkceptuj_Click(object sender, EventArgs e)
        {
            if ((tbNazwisko.Text == "") || (tbImie.Text == "") || (tbTelefon.Text == "" 
                    || tbLogin.Text == "" || tbHaslo.Text == ""))
                System.Windows.Forms.MessageBox.Show("Proszę wypełnić wszystkie pola");
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
                    string Nazwisko = tbNazwisko.Text;
                    string Imie = tbImie.Text;
                    string Login = tbLogin.Text;
                    string Haslo = tbHaslo.Text;
                    int Uprawnienia;
                    if (rbUzytkownik.Checked)
                        Uprawnienia = 0;
                    else 
                        Uprawnienia = 1;
                    TabPracownicy.Dodaj(Imie, Nazwisko, Telefon, Login, Uprawnienia, Haslo);
                    this.Dispose();
                }
            }
        }
    }
}
