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
    public partial class RezerwacjaKortuForm : Form
    {
        string zalogowanyUser;
        DataGridView siatkaKortow;
        DataGridViewCellEventArgs zaznaczonaKomorka;
        DateTime zaznaczonaData;

        public RezerwacjaKortuForm(DateTime wybranaData, string zalogowanyUzytkownik, DataGridView rozkladKortow,
                                    DataGridViewCellEventArgs wybranaKomorka)
        {
            InitializeComponent();            
            zalogowanyUser = zalogowanyUzytkownik;
            siatkaKortow = rozkladKortow;
            zaznaczonaKomorka = wybranaKomorka;
            zaznaczonaData = wybranaData;
            lData.Text += zaznaczonaData.Day.ToString() + "-" + zaznaczonaData.Month.ToString() + "-" + zaznaczonaData.Year.ToString()
                         + ", " + zaznaczonaData.DayOfWeek.ToString();
            List<Uzytkownicy_Kortow> WszyscyUzytkownicy = DBQueries.ZwrocUzytkownikowKortow().ToList();
            //WszyscyUzytkownicy.OrderBy(item => item.Nazwisko).ToList();
            foreach(Uzytkownicy_Kortow Klient in WszyscyUzytkownicy)
            {
                cbKlienci.Items.Add(Klient.Nazwisko + ", " + Klient.Imię + ", " + Klient.ID);
            }
            
        }

        private void btDodajKlienta_Click(object sender, EventArgs e)
        {
            DodajKlientaForm dodanieKLienta = new DodajKlientaForm();
            dodanieKLienta.ShowDialog();
        }

        private void btRezerwuj_Click(object sender, EventArgs e)
        {
            if((cbIloscGodzin.Text == "") || (cbKlienci.Text == ""))
            {
                System.Windows.Forms.MessageBox.Show("Wypełnij wszystkie pola.");
            }
            else
            {
                char[] godziny = this.cbIloscGodzin.Text.ToCharArray();
                int iloscGodzin;
                bool success;
                int idKlienta, idPracownika;
                idPracownika = DBQueries.PobierzIDUzytkownika(zalogowanyUser);
                
                int.TryParse(cbKlienci.Text.Substring( cbKlienci.Text.LastIndexOf(",")+2), out idKlienta);
                if (!(success = int.TryParse(cbIloscGodzin.Text, out iloscGodzin)))
                {
                    System.Windows.Forms.MessageBox.Show("Zły format godzin.");
                }
                else
                {
                    if (iloscGodzin > 1)
                    {
                        for (int i = 1; i < iloscGodzin; i++)
                        {
                            if (siatkaKortow.Rows[zaznaczonaKomorka.RowIndex + i].Cells[zaznaczonaKomorka.ColumnIndex].Style.BackColor == Color.Crimson)
                            {
                                System.Windows.Forms.MessageBox.Show("Wybrano za dużo godzin, nachodzi na kolejną rezerwację!");
                                success = false;
                            }
                        }
                    }
                }
                if (success)
                {
                    if (rbStala.Checked)
                    {
                        List<Rezerwacje_Kortow> rezerwacjeNaDanyDzien;
                        Rezerwacje_Kortow nachodzacaRezerwacja = new Rezerwacje_Kortow();
                        DateTime sprawdzanaData = zaznaczonaData;
                        for (int i = 0; i < 4; i++)
                        {
                            sprawdzanaData = sprawdzanaData.AddDays(7);
                            rezerwacjeNaDanyDzien = DBQueries.ZwrocRezerwacjeDoWalidacji(sprawdzanaData).ToList();
                            foreach (Rezerwacje_Kortow korty in rezerwacjeNaDanyDzien)
                            {
                                if ((korty.Nr_Kortu == zaznaczonaKomorka.ColumnIndex))
                                {
                                    if( (korty.Godz_Rozpoczecia >= (zaznaczonaKomorka.RowIndex + 6)) &&
                                        (korty.Godz_Rozpoczecia <= (zaznaczonaKomorka.RowIndex + 6 + iloscGodzin)) )
                                    {
                                        success = false;
                                        nachodzacaRezerwacja = korty;
                                    }
                                    else if ((korty.Godz_Rozpoczecia >= (zaznaczonaKomorka.RowIndex + 6)) &&
                                        (korty.Godz_Rozpoczecia > (zaznaczonaKomorka.RowIndex + 6 + iloscGodzin)))
                                    {
                                        success = false;
                                        nachodzacaRezerwacja = korty;
                                    }
                                    else if ((korty.Godz_Rozpoczecia < (zaznaczonaKomorka.RowIndex + 6)) &&
                                        (korty.Godz_Zakonczenia > (zaznaczonaKomorka.RowIndex + 6 + iloscGodzin)))
                                    {
                                        success = false;
                                        nachodzacaRezerwacja = korty;
                                    }
                                }                               
                                if (!success)
                                    break;
                            }
                        }
                        if (success)
                        {
                            int nrDniaTygodnia = zwrocNrDniaTygodnia(zaznaczonaData);
                            if (DBQueries.dodajRezerwacjeStala(zaznaczonaKomorka.ColumnIndex, nrDniaTygodnia, zaznaczonaKomorka.RowIndex + 6,
                                                     zaznaczonaKomorka.RowIndex + 6 + iloscGodzin, idKlienta, 10 * iloscGodzin, idPracownika))
                            {
                                System.Windows.Forms.MessageBox.Show("Dodano rezerwację");
                            }
                            else
                                System.Windows.Forms.MessageBox.Show("Wystąpił błąd");
                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show("Nachodzi na rezerwację w przyszłości: ID " +
                                                    nachodzacaRezerwacja.ID_Rezerwacji + ": godz. " +
                                                    nachodzacaRezerwacja.Godz_Rozpoczecia + " - " + 
                                                    nachodzacaRezerwacja.Godz_Zakonczenia);
                        }
                    }
                    else
                    {
                        if(DBQueries.dodajRezerwacjeJednorazowa(zaznaczonaKomorka.ColumnIndex, zaznaczonaData, zaznaczonaKomorka.RowIndex + 6,
                                                 zaznaczonaKomorka.RowIndex + 6 + iloscGodzin, idKlienta, 10 * iloscGodzin, idPracownika))
                        {
                            System.Windows.Forms.MessageBox.Show("Dodano rezerwację");
                        }
                        else
                            System.Windows.Forms.MessageBox.Show("Wystąpił błąd");
                    }
                    //DBQueries.dodajRezerwacje(zaznaczonaKomorka.ColumnIndex, 
                }
            }
        }

        public static int zwrocNrDniaTygodnia(DateTime dzienTygodnia)
        {
            
            switch (dzienTygodnia.DayOfWeek.ToString())
            {
                case "Monday":
                    return 1;
                    break;
                case "Tuesday":
                    return 2;
                    break;
                case "Wednesday":
                    return 3;
                    break;
                case "Thursday":
                    return 4;
                    break;
                case "Friday":
                    return 5;
                    break;
                case "Saturday":
                    return 6;
                    break;
                case "Sunday":
                    return 7;
                    break;
                default:
                    return 0;
                    break;
            }

        }
    }
}
