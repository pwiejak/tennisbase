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
    public partial class EdytujWynikForm : Form
    { 
        int m_id, m_idmeczu;
        string set1, set2, set3, set4, set5;

        public EdytujWynikForm(Mecze mecz)
        {
            InitializeComponent();
            m_id = mecz.ID_Turnieju;
            m_idmeczu = mecz.ID_Meczu;
            TabKlasyfikacje.WczytajTurniej(rDDLTurniej);
            TabKlasyfikacje.WczytajZawodnika(m_id, rDDLZawodnik1);
            TabKlasyfikacje.WczytajZawodnika(m_id, rDDLZawodnik2);
            this.rDDLTurniej.SelectedValue = mecz.ID_Turnieju;
            this.rDDLZawodnik1.SelectedValue = mecz.Zawodnik1;
            this.rDDLZawodnik2.SelectedValue = mecz.Zawodnik2;
            rtbSet1.Text = mecz.Set1;
            rtbSet2.Text = mecz.Set2;
            rtbSet3.Text = mecz.Set3;
            rtbSet4.Text = mecz.Set4;
            rtbSet5.Text = mecz.Set5;
            rDDLTurniej.Enabled = false;
            rDDLZawodnik1.Enabled = false;
            rDDLZawodnik2.Enabled = false;

            if ((mecz.Set3 == "---") && (mecz.Set4 == "---") && (mecz.Set5 == "---"))
            {
                rrb2Sety.IsChecked = true;
                rtbSet1.Enabled = true;
                rtbSet2.Enabled = true;
                rtbSet3.Enabled = false;
                rtbSet4.Enabled = false;
                rtbSet5.Enabled = false;
            }
            else
            {
                if ((mecz.Set3 != "---") && (mecz.Set4 == "---") && (mecz.Set5 == "---"))
                {
                    rrb2Sety.IsChecked = true;
                    rtbSet1.Enabled = true;
                    rtbSet2.Enabled = true;
                    rtbSet3.Enabled = true;
                    rtbSet4.Enabled = false;
                    rtbSet5.Enabled = false;
                }
                else
                {
                    if ((mecz.Set3 != "---") && (mecz.Set4 != "---") && (mecz.Set5 == "---"))
                    {
                        rrb2Sety.IsChecked = true;
                        rtbSet1.Enabled = true;
                        rtbSet2.Enabled = true;
                        rtbSet3.Enabled = true;
                        rtbSet4.Enabled = true;
                        rtbSet5.Enabled = false;
                    }
                    else
                    {
                        if ((mecz.Set3 != "---") && (mecz.Set4 != "---") && (mecz.Set5 != "---"))
                        {
                            rrb5Setow.IsChecked = true;
                            rtbSet1.Enabled = true;
                            rtbSet2.Enabled = true;
                            rtbSet3.Enabled = true;
                            rtbSet4.Enabled = true;
                            rtbSet5.Enabled = true;
                        }
                    }
                }
            }
        }



        private void rbtAnuluj_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void rbtOK_Click(object sender, EventArgs e)
        {
            if (rrb2Sety.IsChecked)
            {
                set1 = rtbSet1.Text;
                set2 = rtbSet2.Text;
                set3 = "---";
                set4 = "---";
                set5 = "---";
            }

            if (rrb3Sety.IsChecked)
            {
                set1 = rtbSet1.Text;
                set2 = rtbSet2.Text;
                set3 = rtbSet3.Text;
                set4 = "---";
                set5 = "---";
            }
            
            if (rrb4Sety.IsChecked)
            {
                set1 = rtbSet1.Text;
                set2 = rtbSet2.Text;
                set3 = rtbSet3.Text;
                set4 = rtbSet4.Text;
                set5 = "---";
            }

            if (rrb5Setow.IsChecked)
            {
                set1 = rtbSet1.Text;
                set2 = rtbSet2.Text;
                set3 = rtbSet3.Text;
                set4 = rtbSet4.Text;
                set5 = rtbSet5.Text;
            }


            if ((set1 == "") || (set2 == "") || (set3 == "") || (set4 == "") || (set5 == ""))
            {
                System.Windows.Forms.MessageBox.Show("Proszę wypełnić wszystkie pola.");
            }
            else
            {
                if (DBQueries.EdytujWynik(m_idmeczu, set1, set2, set3, set4, set5) == true)
                {
                    MessageBox.Show("Edytowano poprawnie");
                    this.Dispose();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Wystąpił błąd.");
                }
            }
       }

        private void rrb2Sety_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            rtbSet1.Enabled = true;
            rtbSet2.Enabled = true;
            rtbSet3.Enabled = false;
            rtbSet4.Enabled = false;
            rtbSet5.Enabled = false;
        }

        private void rrb3Sety_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            rtbSet1.Enabled = true;
            rtbSet2.Enabled = true;
            rtbSet3.Enabled = true;
            rtbSet4.Enabled = false;
            rtbSet5.Enabled = false;
        }

        private void rrb4Sety_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            rtbSet1.Enabled = true;
            rtbSet2.Enabled = true;
            rtbSet3.Enabled = true;
            rtbSet4.Enabled = true;
            rtbSet5.Enabled = false;
        }

        private void rrb5Setow_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            rtbSet1.Enabled = true;
            rtbSet2.Enabled = true;
            rtbSet3.Enabled = true;
            rtbSet4.Enabled = true;
            rtbSet5.Enabled = true;
        }



    }
}
