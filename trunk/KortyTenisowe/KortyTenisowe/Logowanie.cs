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
    public partial class Logowanie : Form
    {
        public string login;
        public Logowanie()
        {
            InitializeComponent();        
        }

        private void btLogowanie_Click(object sender, EventArgs e)
        {
            string haslo;
            login = tbLogin.Text;
            haslo = tbHaslo.Text;
            DBQueries DBQuery = new DBQueries();
            bool success = DBQuery.Logowanie(login, haslo);
            if (success)
            {
                //System.Windows.Forms.MessageBox.Show("Udalo sie");
                /*MainForm FormaGlowna = new MainForm();
                FormaGlowna.Activate();
                FormaGlowna.Show();*/
                this.DialogResult = DialogResult.OK;
            }
            else
                System.Windows.Forms.MessageBox.Show("Nie bangla ;( ");

        }

        private void tbHaslo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                this.btLogowanie_Click(this, null);
            }
        }

        private void tbLogin_MouseClick(object sender, MouseEventArgs e)
        {
            this.tbLogin.Text = "";
        }

        private void tbHaslo_MouseClick(object sender, MouseEventArgs e)
        {
            this.tbHaslo.Text = "";
        }
    }
}
