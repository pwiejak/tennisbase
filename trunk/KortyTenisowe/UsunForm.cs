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

    public partial class UsunForm : Telerik.WinControls.UI.RadForm
    {
        int m_id, m_nad;        

        public UsunForm(int id, int nad)
        {
            InitializeComponent();
            m_id = id;
            m_nad = nad;
        }

        private void rbtNie_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void rbtTak_Click(object sender, EventArgs e)
        {

            switch (m_nad)
            {
                case 1:

                    if (DBQueries.CzyGeneralna(m_id) == true)
                    {
                        Generalna usuwanaGeneralna = DBQueries.ZwrocGeneralnaZawodnika(m_id);
                        DBQueries.UsunGeneralnaZawodnika(usuwanaGeneralna);
                    }
                    if (DBQueries.CzyMecze(m_id) == true)
                    {
                        IEnumerable<Mecze> usuwaneMecze = DBQueries.ZwrocMeczeZawodnika(m_id).ToList();
                        DBQueries.UsunMeczeZawodnika(usuwaneMecze);
                    }
                    if (DBQueries.CzyKlasyfikacje(m_id) == true)
                    {
                        IEnumerable<Klasyfikacje> usuwaneKlasyfikacje = DBQueries.ZwrocKlasyfikacjeZawodnika(m_id).ToList();
                        DBQueries.UsunKlasyfikacjeZawodnika(usuwaneKlasyfikacje);
                    }
                    if (DBQueries.CzyTurnieje(m_id) == true)
                    {
                        IEnumerable<ListaGraczy> usuwaneTurnieje = DBQueries.ZwrocTurniejeZawodnika(m_id).ToList();
                        DBQueries.UsunTurniejeZawodnika(usuwaneTurnieje);
                    }
                    DBQueries.UsunZawodnika(m_id);
                    break;

                case 2:
                    DBQueries.UsunTurniej(m_id);
                    break;
                case 3:

                    DBQueries.UsunMecz(m_id);
                    break;
                
                case 4:

                    DBQueries.UsunListaGraczy(m_id);
                    break;

                case 5: DBQueries.OdejmijGeneralna(m_id);
                        DBQueries.UsunKlasyfikacjePoID(m_id);
                        break;

                case 6: DBQueries.UsunKlasyfikacjePoID(m_id);
                        break;

                case 7: DBQueries.UsunMecz(m_id);
                        break;


                default:
                    break;
            }

                System.Windows.Forms.MessageBox.Show("Usunięto.");
                this.Dispose();

        }
    }
}
