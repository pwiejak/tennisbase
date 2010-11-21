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
    public partial class DodajKategorieForm : Form
    {
        Telerik.WinControls.UI.RadDropDownList m_lista;
        public DodajKategorieForm(Telerik.WinControls.UI.RadDropDownList listaKategorii)
        {
            InitializeComponent();
            m_lista = listaKategorii;
        }

        private void rbDodaj_Click(object sender, EventArgs e)
        {
            if ((tbKategoria.Text == "") || (tbKategoria.Text == "Nazwa kategorii"))
            {
                System.Windows.Forms.MessageBox.Show("Podaj nazwę kategorii");
            }
            else
            {
                bool istnieje = false;
                for (int i = 0; i < m_lista.Items.Count; i++)
                {
                    if (m_lista.Items[i].Text == tbKategoria.Text)
                    {
                        System.Windows.Forms.MessageBox.Show("Istnieje już taka kategoria");
                        istnieje = true;
                        break;
                    }

                }
                if (!istnieje)
                {
                    if (DBQueries.dodajNowaKategorie(tbKategoria.Text))
                    {
                        System.Windows.Forms.MessageBox.Show("Dodano");
                    }
                }
            }
        }
    }
}
