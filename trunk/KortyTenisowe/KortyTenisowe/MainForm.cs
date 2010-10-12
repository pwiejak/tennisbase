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
        public MainForm(string login)
        {
            InitializeComponent();
            zalogowanyUzytkownik = login;
            this.Text += ": " + zalogowanyUzytkownik;
        }
    }
}
