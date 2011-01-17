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
    public partial class DodajKlasyfikacjeForm : Form
    {
        public DodajKlasyfikacjeForm()
        {
            InitializeComponent();
            rtbPunkty.Enabled = false;
            TabKlasyfikacje.WczytajTurniej(rDDLTurniej);
            
        }

        private void rDDLTurniej_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            int m_id = Convert.ToInt32(rDDLTurniej.SelectedValue);
            TabKlasyfikacje.WczytajZawodnika(m_id, rDDLZawodnik);

        }

        public void edytujGeneralna(int idzawodnika, int punkty)
        {
            bool generalna = DBQueries.ZwrocGeneralna(idzawodnika);

            if (generalna == false)
            {
                DBQueries.DodajGeneralna(idzawodnika, punkty);
            }
            else
            {
                DBQueries.EdytujGeneralna(idzawodnika, punkty);
            }
        }


        private void rcbCzyGeneralna_PropertyChanged(object sender, EventArgs e)
        {
            if (rcbCzyGeneralna.IsChecked == true) rtbPunkty.Enabled = true;
            else rtbPunkty.Enabled = false;
        }



        private void rbtAnuluj_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void rbtOK_Click(object sender, EventArgs e)
        {
            if (rcbCzyGeneralna.IsChecked == false)
            {
              if ((rDDLZawodnik.SelectedIndex == -1) || (rDDLTurniej.SelectedIndex == -1) || (rtbMiejsce.Text == ""))
              {
                  System.Windows.Forms.MessageBox.Show("Proszę wypełnić wszystkie pola");
              }
              else
              {
                  int idturnieju = Convert.ToInt32(rDDLTurniej.SelectedValue);
                  int idzawodnika = Convert.ToInt32(rDDLZawodnik.SelectedValue);
                  int m_miejsce = -1;
                  bool klasyfikacja = DBQueries.ZwrocKlasyfikacje(idturnieju, idzawodnika);
                  try
                  {
                      int miejsce = Convert.ToInt32(rtbMiejsce.Text);
                      m_miejsce = miejsce;
                  }
                  catch (FormatException exc)
                  {
                      Console.WriteLine("Wprowadzona wartość miejsca nie jest poprawną liczbą!");
                  }
                  if (klasyfikacja == false)
                  {
                      if (m_miejsce > 0) DBQueries.DodajKlasyfikacje(idturnieju, 0, m_miejsce, 0, idzawodnika);
                      else Console.WriteLine("Wprowadzona wartość miejsca nie jest poprawna!");
                      this.Dispose();
                  }
                  else System.Windows.Forms.MessageBox.Show("Podany zawodnik jest już sklasyfikowany w tym turnieju");
              
                  

              }
            }
            else
            {
                if ((rDDLZawodnik.SelectedIndex == -1) || (rDDLTurniej.SelectedIndex == -1) || (rtbMiejsce.Text == "") || (rtbPunkty.Text == ""))
                {
                    System.Windows.Forms.MessageBox.Show("Proszę wypełnić wszystkie pola");
                }
                else
                {
                    int idturnieju = Convert.ToInt32(rDDLTurniej.SelectedValue);
                    int idzawodnika = Convert.ToInt32(rDDLZawodnik.SelectedValue);
                    int m_miejsce = -1;
                    int m_punkty = -1;
                    try
                    {
                        int miejsce = Convert.ToInt32(rtbMiejsce.Text);
                        m_miejsce = miejsce;
                    }
                    catch (FormatException exc)
                    {
                        Console.WriteLine("Wprowadzona wartość miejsca nie jest poprawną liczbą!");
                    }
                    try
                    {
                        int punkty = Convert.ToInt32(rtbPunkty.Text);
                        m_punkty = punkty;
                    }
                    catch (FormatException exc)
                    {
                        Console.WriteLine("Wprowadzona wartość punktów nie jest poprawną liczbą!");
                    }
                    if ((m_miejsce > 0) && (m_punkty > 0))
                    {
                        DBQueries.DodajKlasyfikacje(idturnieju, 1, m_miejsce, m_punkty, idzawodnika);
                        edytujGeneralna(idzawodnika, m_punkty);
                        this.Dispose();
                    }
                    else Console.WriteLine("Wprowadzona wartość nie jest poprawna!");
                }

            }
        }
    }
}
