﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KortyTenisowe
{
    public partial class DodajTurniejForm : Form
    {
        public DodajTurniejForm()
        {
            InitializeComponent();
        }

        private void rbtAnuluj_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
