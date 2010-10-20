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
    public partial class MainForm : Form
    {
        string zalogowanyUzytkownik;
        int poziomUprawnien;
        List<Rezerwacje_Kortow> zarezerwowaneKorty;
        public MainForm(string login, int Uprawnienie)
        {
            InitializeComponent();
            zalogowanyUzytkownik = login;
            poziomUprawnien = Uprawnienie;
            this.Text += ": " + zalogowanyUzytkownik;
            zarezerwowaneKorty = new List<Rezerwacje_Kortow>();
        }

        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btDodajPracownika_Click(object sender, EventArgs e)
        {
            KortyTenisowe.DodawaniePracownikaForm DodaniePracownika = new KortyTenisowe.DodawaniePracownikaForm();
            DodaniePracownika.Activate();
            DodaniePracownika.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (this.poziomUprawnien == 0)
            {
                tcMainForm.TabPages.Remove(tabPracownicy);
            }

            for (int i = 0; i < 15; i++)
            {
                dgKorty.Rows.Add();
            }

            for (int i = 0; i < 16; i++)
            {
                dgKorty.Rows[i].Cells[0].Value = (i + 6) + "-" + (i + 7);
                dgKorty.Rows[i].Cells[0].Style.BackColor = Color.LightGray;
            }
        }

        private void Kalendarz_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime wybranyDzien = e.Start.Date;          
            List<Rezerwacje_Kortow> korty = TabKorty.PobierzRezerwacje(wybranyDzien);
            this.zarezerwowaneKorty = korty;

            for (int i = 1; i < 5; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    dgKorty.Rows[j].Cells[i].Style.BackColor = Color.White;
                }
            }

            for (int kolejnyKort = 1; kolejnyKort < 5; kolejnyKort++)
            {
                for (int iloscRezerwacji = 0; iloscRezerwacji < korty.Count; iloscRezerwacji++)
                {
                    if (korty[iloscRezerwacji].Nr_Kortu == kolejnyKort)
                    {
                        int iloscGodzin = korty[iloscRezerwacji].Godz_Zakonczenia - korty[iloscRezerwacji].Godz_Rozpoczecia;
                        for (int k = 0; k < iloscGodzin; k++)
                        {
                            dgKorty.Rows[korty[iloscRezerwacji].Godz_Rozpoczecia + (k - 6)].Cells[kolejnyKort].Style.BackColor = Color.Crimson;
                        }
                    }
                }
            }
            
            //TabKorty.OdswiezKorty(zarezerwowaneKorty, dgKorty);
        }
    }
}
