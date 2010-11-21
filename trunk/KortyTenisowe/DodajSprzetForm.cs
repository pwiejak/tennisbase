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
    public partial class DodajSprzetForm : Form
    {
        public DodajSprzetForm()
        {
            InitializeComponent();
            List<Typy> listaTypow = new List<Typy>();
            listaTypow = DBQueries.ZwrocTypy().ToList();
            for(int i=0; i<listaTypow.Count; i++)
            {
                cbKategoria.Items.Add(listaTypow[i].Nazwa);
            }
        }

        private void btDodaj_Click(object sender, EventArgs e)
        {
            if ((tbMarka.Text == "") || (tbModel.Text == "") || (cbKategoria.SelectedIndex == -1))
            {
                System.Windows.Forms.MessageBox.Show("Wypełnij wszystkie pola");
            }
            else
            {
                if (tbOpis.Text == null)
                {
                    DBQueries.dodajSprzet(cbKategoria.SelectedIndex, tbMarka.Text, tbModel.Text, null);
                }
                else
                {
                    DBQueries.dodajSprzet(cbKategoria.SelectedIndex, tbMarka.Text, tbModel.Text, tbOpis.Text);
                }
            }
            
        }

        private void rbtDodaj_Click(object sender, EventArgs e)
        {
            if ((tbMarka.Text == "") || (tbModel.Text == "") || (cbKategoria.SelectedIndex == -1))
            {
                System.Windows.Forms.MessageBox.Show("Wypełnij wszystkie pola");
            }
            else
            {
                if (tbOpis.Text == null)
                {
                    if(DBQueries.dodajSprzet(cbKategoria.SelectedIndex, tbMarka.Text, tbModel.Text, null))
                        System.Windows.Forms.MessageBox.Show("Dodano");
                }
                else
                {
                    if(DBQueries.dodajSprzet(cbKategoria.SelectedIndex, tbMarka.Text, tbModel.Text, tbOpis.Text))
                        System.Windows.Forms.MessageBox.Show("Dodano");
                }
            }
        }
    }
}
