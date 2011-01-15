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
    public partial class ZaplanujMeczForm : Form
    {
        public ZaplanujMeczForm()
        {
            InitializeComponent();
            TabTurnieje.WczytajTurniej(rDDLTurniej);
        }


        private void rDDLTurniej_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            int m_id = Convert.ToInt32(rDDLTurniej.SelectedValue);
            TabTurnieje.WczytajZawodnika(m_id, rDDLZawodnik1);
            TabTurnieje.WczytajZawodnika(m_id, rDDLZawodnik2);

        }

        private void rbtAnuluj_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void rbtZaplanuj_Click(object sender, EventArgs e)
        {

            if ((rDDLTurniej.SelectedIndex == -1) || (rDDLTurniej.SelectedIndex == -1) || (rDDLTurniej.SelectedIndex == -1))
            {
                System.Windows.Forms.MessageBox.Show("Proszę wypełnić wszystkie pola");
            }
            else
            {
                if (rDDLZawodnik1.SelectedIndex == rDDLZawodnik2.SelectedIndex)
                {
                    System.Windows.Forms.MessageBox.Show("Proszę wybrać dwóch różnych zawodników");
                }
                else
                {
                    int m_id = Convert.ToInt32(rDDLTurniej.SelectedValue);
                    int ID_Turnieju = m_id;
                    m_id = Convert.ToInt32(rDDLZawodnik1.SelectedValue);
                    int Zawodnik1 = m_id;
                    m_id = Convert.ToInt32(rDDLZawodnik2.SelectedValue);
                    int Zawodnik2 = m_id;


                    if (DBQueries.ZaplanujMecz(ID_Turnieju, Zawodnik1, Zawodnik2) == true)
                    {
                        MessageBox.Show("Zaplanowano");
                        this.Dispose();
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Wystąpił błąd.");
                    }
                }
            }


            //private void rDDLZawodnik1_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
            //{
            //    ZwrocZawodnikow(e.Position + 1, rgvZawodnicy);
            //    rbtEdytujZawodnika.Enabled = false;
            //    rbtUsunZawodnika.Enabled = false;

            //}

            //private void rDDLZawodnik2_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
            //{
            //    ZwrocZawodnikow(e.Position + 1, rgvZawodnicy);
            //    rbtEdytujZawodnika.Enabled = false;
            //    rbtUsunZawodnika.Enabled = false;

            //}





        }
    }
}

