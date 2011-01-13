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
        int aktualnaKomorka;
        int doWypozyczenia;
        static DateTime wybranyDzien;
        List<Rezerwacje_Kortow> zarezerwowaneKorty;
        public MainForm(string login, int Uprawnienie)
        {
            InitializeComponent();
            zalogowanyUzytkownik = login;
            poziomUprawnien = Uprawnienie;
            this.Text += ": " + zalogowanyUzytkownik;
            zarezerwowaneKorty = new List<Rezerwacje_Kortow>();
            wybranyDzien = DateTime.Now;
            TabSprzet.WczytajKategorie(rDDLKategorie);
            TabMagazyn.WczytajKategorie(rddlKategorieMagazyn);
            TabWypozyczalnia.PokazWypozyczenia(rgvWypozyczalnia);
            TabTurnieje.ZwrocTurnieje(rgvTurnieje);
            TabWypozyczalnia.PokazStany(rddlStan);
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
                tcMainForm.TabPages.Remove(tabZarzadzanie);
            }

            for (int i = 0; i < 15; i++)
            {
                dgKorty.Rows.Add();             
            }

            for (int i = 0; i < 16; i++)
            {
                dgKorty.Rows[i].Cells[0].Value = (i + 6) + "-" + (i + 7);
                rgvKorty.Rows.Add((i + 6) + "-" + (i + 7), "", "", "", "");
                dgKorty.Rows[i].Cells[0].Style.BackColor = Color.LightGray;
            }
            btDodajPracownika.BackColor = Color.FromArgb(100, SystemColors.Control);
            btDodajKlienta.BackColor = Color.FromArgb(100, SystemColors.Control);
        }

        private void Kalendarz_DateChanged(object sender, DateRangeEventArgs e)
        {
            wybranyDzien = e.Start.Date;
            TabKorty temp = new TabKorty();
            List<Rezerwacje_Kortow> korty = temp.PobierzRezerwacje(wybranyDzien);
            this.zarezerwowaneKorty = korty;

            for (int i = 1; i < 5; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    dgKorty.Rows[j].Cells[i].Style.BackColor = Color.White;
                    rgvKorty.Rows[j].Cells[i].Style.BackColor = Color.White;
                }
            }

            for (int kolejnyKort = 1; kolejnyKort < 5; kolejnyKort++)
            {
                for (int iloscRezerwacji = 0; iloscRezerwacji < korty.Count; iloscRezerwacji++)
                {
                    if (korty[iloscRezerwacji].Nr_Kortu == kolejnyKort)
                    {
                        int iloscGodzin = korty[iloscRezerwacji].Godz_Zakonczenia - korty[iloscRezerwacji].Godz_Rozpoczecia;
                        if ((korty[iloscRezerwacji].Dzien_Tygodnia) == null)
                        {
                            for (int k = 0; k < iloscGodzin; k++)
                            {
                                dgKorty.Rows[korty[iloscRezerwacji].Godz_Rozpoczecia + (k - 6)].Cells[kolejnyKort].Style.BackColor = Color.Crimson;
                                rgvKorty.Rows[korty[iloscRezerwacji].Godz_Rozpoczecia + (k - 6)].Cells[kolejnyKort].Style.BackColor = Color.Crimson;
                            }
                        }
                        else
                        {
                            for (int k = 0; k < iloscGodzin; k++)
                            {
                                dgKorty.Rows[korty[iloscRezerwacji].Godz_Rozpoczecia + (k - 6)].Cells[kolejnyKort].Style.BackColor = Color.Black;
                                Telerik.WinControls.UI.GridViewRowInfo bla;
                                bla = rgvKorty.Rows[korty[iloscRezerwacji].Godz_Rozpoczecia + (k - 6)];
                                
                                rgvKorty.Rows[korty[iloscRezerwacji].Godz_Rozpoczecia + (k - 6)].Cells[kolejnyKort].Style.BackColor = Color.Black;
                                rgvKorty.Rows[korty[iloscRezerwacji].Godz_Rozpoczecia + (k - 6)].Cells[kolejnyKort].Style.DrawFill = true;
                                
                            }
                        }
                    }
                }
            }
            
            //TabKorty.OdswiezKorty(zarezerwowaneKorty, dgKorty);
        }

        private void dgKorty_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((dgKorty.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor) == Color.Crimson)
            {
                TabKorty temp = new TabKorty();
                temp.WyswietlAktualnaRezerwacjeJednorazowa(dgKorty, e, rtbInformacja, wybranyDzien);
            }
            else if ((dgKorty.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor) == Color.Black)
            {
                TabKorty temp = new TabKorty();
                temp.WyswietlAktualnaRezerwacjeStala(dgKorty, e, rtbInformacja, wybranyDzien);
            }
            else if(    (dgKorty.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor) == Color.Black)
            {
                rtbInformacja.Text = "";
            }

        }

        private void dgKorty_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((dgKorty.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor) == Color.Crimson)
            {
                System.Windows.Forms.MessageBox.Show("Nie można dokonać rezerwacji!");
            }
            else
            {
                //System.Windows.Forms.MessageBox.Show("Kliknięto komórkę ["+e.ColumnIndex +"] ["+ e.RowIndex+"]");
                RezerwacjaKortuForm rezerwacja = new RezerwacjaKortuForm(wybranyDzien.Date, zalogowanyUzytkownik, dgKorty, e);
                rezerwacja.ShowDialog();
            }
        }

        private void btDodajSprzet_Click(object sender, EventArgs e)
        {
            DodajSprzetForm dodanieSprzetu = new DodajSprzetForm();
            dodanieSprzetu.ShowDialog();
        }

        private void rbtDodajNowy_Click(object sender, EventArgs e)
        {
            DodajSprzetForm dodanieSprzetu = new DodajSprzetForm();
            dodanieSprzetu.ShowDialog();
        }

        private void rDDLKategorie_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            /*List<Sprzet> m_lista = new List<Sprzet>();
            m_lista = DBQueries.zwrocSprzetWgTypu(e.Position+1).ToList<Sprzet>();
             */
            TabSprzet.PokazSprzetWgTypu(e.Position + 1, rgvSprzet);
            rbDodajNaMagazyn.Enabled = false;
        }

        private void rbNowyTyp_Click(object sender, EventArgs e)
        {
            DodajKategorieForm dodanieKategorii = new DodajKategorieForm(rDDLKategorie);
            dodanieKategorii.ShowDialog();
            TabSprzet.WczytajKategorie(rDDLKategorie);
        }

        private void rddlKategorieMagazyn_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            TabMagazyn.PokazStanMagazynuWgTypu(e.Position + 1, rgvMagazyn);
            rbtZmienIlosc.Enabled = false;
            rbtUsun.Enabled = false;
            rbtWypozycz.Enabled = false;
        }

        private void rbtSzukajWgID_Click(object sender, EventArgs e)
        {
            try
            {
                int idPrzedmiotu = int.Parse(rtbIDProduktu.Text);
                TabMagazyn.PokazPrzedmiotWgID(idPrzedmiotu, rgvMagazyn);
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Podaj poprawną wartość");
            }            
        }

        private void rtbIDProduktu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                this.rbtSzukajWgID_Click(this, null);
            }
        }

        private void rgvSprzet_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            rbDodajNaMagazyn.Enabled = true;
            aktualnaKomorka = int.Parse(rgvSprzet.Rows[e.RowIndex].Cells[0].Value.ToString());           
        }

        private void rbDodajNaMagazyn_Click(object sender, EventArgs e)
        {
            TabSprzet.DodajSprzetNaMagazyn(aktualnaKomorka);
        }

        private void rgvMagazyn_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            rbtZmienIlosc.Enabled = true;
            rbtUsun.Enabled = true;
            try
            {
                if (rgvMagazyn.Rows[e.RowIndex].Cells[7].Value.ToString() == "Tak")
                {
                    doWypozyczenia = 1;
                    rbtWypozycz.Enabled = true;
                }
            }
            catch (Exception )
            {
                doWypozyczenia = 0;
                rbtWypozycz.Enabled = false;
            }

            if (e.RowIndex != -1)
            {
                aktualnaKomorka = int.Parse(rgvMagazyn.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void rbtZmienIlosc_Click(object sender, EventArgs e)
        {
            ZmienIloscForm zmianaIlosci = new ZmienIloscForm(aktualnaKomorka);
            zmianaIlosci.ShowDialog();
            rddlKategorieMagazyn.SelectedIndex = rddlKategorieMagazyn.SelectedIndex-1;
            rddlKategorieMagazyn.SelectedIndex++;
        }

        private void rbtUsun_Click(object sender, EventArgs e)
        {
            PotwierdzenieForm potwierdz = new PotwierdzenieForm(aktualnaKomorka);
            potwierdz.ShowDialog();
            rddlKategorieMagazyn.SelectedIndex = rddlKategorieMagazyn.SelectedIndex - 1;
            rddlKategorieMagazyn.SelectedIndex++;
        }

        private void btDodajKlienta_Click_1(object sender, EventArgs e)
        {
            DodajKlientaForm dodanieKLienta = new DodajKlientaForm();
            dodanieKLienta.ShowDialog();
        }

        private void rddlStan_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            TabWypozyczalnia pokazDlaStanu = new TabWypozyczalnia();
            pokazDlaStanu.PokazDlaDanegoStanu(rgvWypozyczalnia, e.Position + 1);
        }

        private void rbtWypozycz_Click(object sender, EventArgs e)
        {
                WypozyczenieForm wypozycz = new WypozyczenieForm(aktualnaKomorka);
                wypozycz.ShowDialog();
        }

        private void rbtObslugaTurnieju_Click(object sender, EventArgs e)
        {
            KortyTenisowe.ObslugaTurniejuForm ObslugaTurnieju = new KortyTenisowe.ObslugaTurniejuForm();
            ObslugaTurnieju.Activate();
            ObslugaTurnieju.ShowDialog();

        }


        private void rbtDodajTurniej_Click(object sender, EventArgs e)
        {
            KortyTenisowe.DodajTurniejForm DodajTurniej = new KortyTenisowe.DodajTurniejForm();
            DodajTurniej.Activate();
            DodajTurniej.ShowDialog();
            TabTurnieje.ZwrocTurnieje(rgvTurnieje);
        }

        private void rbtUsunTurniej_Click(object sender, EventArgs e)
        {
            KortyTenisowe.UsunForm Usun = new KortyTenisowe.UsunForm(aktualnaKomorka, 2);
            Usun.Activate();
            Usun.ShowDialog();
            TabTurnieje.ZwrocTurnieje(rgvTurnieje);
        }

        private void rbtDodajKlasyfikacje_Click(object sender, EventArgs e)
        {
            KortyTenisowe.DodajKlasyfikacjeForm DodajKlasyfikacje = new KortyTenisowe.DodajKlasyfikacjeForm();
            DodajKlasyfikacje.Activate();
            DodajKlasyfikacje.ShowDialog();
        }

        private void rbtUsunKlasyfikacje_Click(object sender, EventArgs e)
        {
            KortyTenisowe.UsunForm Usun = new KortyTenisowe.UsunForm(aktualnaKomorka, 3);
            Usun.Activate();
            Usun.ShowDialog();
        }

        private void rbtWynikiSpotkan_Click(object sender, EventArgs e)
        {
            KortyTenisowe.WynikiForm Wyniki = new KortyTenisowe.WynikiForm();
            Wyniki.Activate();
            Wyniki.ShowDialog();
        }

        private void rgvTurnieje_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            aktualnaKomorka = int.Parse(rgvTurnieje.Rows[e.RowIndex].Cells[0].Value.ToString());           
        }

        private void rgvKlasyfikacje_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            aktualnaKomorka = int.Parse(rgvKlasyfikacje.Rows[e.RowIndex].Cells[0].Value.ToString());
        }
        

    }
}
