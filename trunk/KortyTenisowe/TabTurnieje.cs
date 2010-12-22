using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KortyTenisowe
{
    class TabTurnieje
    {
        public static void ZwrocTurnieje(Telerik.WinControls.UI.RadGridView dataGrid)
        {
            List<Turnieje> WszystkieTurnieje = DBQueries.ZwrocTurnieje().ToList();
            
            dataGrid.Rows.Clear();
            for (int i = 0; i < WszystkieTurnieje.Count; i++)
            {
                dataGrid.Rows.Add(WszystkieTurnieje[i].ID_Turnieju, WszystkieTurnieje[i].Nazwa, WszystkieTurnieje[i].Opis, WszystkieTurnieje[i].Kategoria);
            }
        }
    }
}
