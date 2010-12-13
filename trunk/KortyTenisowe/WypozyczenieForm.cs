using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using System.Linq;

namespace KortyTenisowe
{
    public partial class WypozyczenieForm : Telerik.WinControls.UI.RadForm
    {
        int id;
        DateTime dataRozpoczecia, dataZakonczenia;

        public WypozyczenieForm(int aktualneId)
        {
            InitializeComponent();
            id = aktualneId;

            List<Uzytkownicy_Kortow> klienciKortow = DBQueries.ZwrocUzytkownikowKortow().ToList();
            foreach (Uzytkownicy_Kortow Klient in klienciKortow)
            {
                Telerik.WinControls.UI.RadListDataItem element = new Telerik.WinControls.UI.RadListDataItem();
                element.Text = Klient.Nazwisko + ", " + Klient.Imiê + ", " + Klient.ID;
                rddlKlienci.Items.Add(element);
            }
        }

        private void rbtZatwierdz_Click(object sender, EventArgs e)
        {
            int idKLienta;
            int.TryParse(rddlKlienci.Text.Substring(rddlKlienci.Text.LastIndexOf(",") +2), out idKLienta);
            if (dataRozpoczecia != dataZakonczenia)
            {
                if (DBQueries.DodajWypozyczenie(id, idKLienta, dataRozpoczecia, 0, dataZakonczenia, 0))
                {
                    System.Windows.Forms.MessageBox.Show("Dodano rezerwacjê sprzêtu");
                }
            }
            else
            {
                try
                {
                    int godzRozpoczecia, godzZakonczenia;
                    int.TryParse(rtbGodzinaStart.Text, out godzRozpoczecia);
                    int.TryParse(rtbGodzinaEnd.Text, out godzZakonczenia);

                    if(DBQueries.DodajWypozyczenie(id, idKLienta, dataRozpoczecia, godzRozpoczecia, dataZakonczenia, godzZakonczenia))
                    {
                        MessageBox.Show("Dodano rezerwacjê sprzêtu");
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Wyst¹pi³ b³¹d, popraw wszystkie pola i spróbuj ponownie");
                }
            }

            this.Dispose();

        }

        private void dtpWypozyczenieStart_ValueChanged(object sender, EventArgs e)
        {
            dataRozpoczecia = dtpWypozyczenieStart.Value;
            dtpWypozyczenieEnd.Value = dtpWypozyczenieStart.Value;
        }

        private void dtpWypozyczenieEnd_ValueChanged(object sender, EventArgs e)
        {
            dataZakonczenia = dtpWypozyczenieEnd.Value;
        }
    }
}
