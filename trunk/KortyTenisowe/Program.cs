using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace KortyTenisowe
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LogowanieForm oknoLogowania = new LogowanieForm();
            if (oknoLogowania.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MainForm(oknoLogowania.login, KortyTenisowe.LogowanieForm.poziomUprawnien));
            }
        }
    }
}
