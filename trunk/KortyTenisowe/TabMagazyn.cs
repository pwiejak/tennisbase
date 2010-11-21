using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KortyTenisowe
{
    class TabMagazyn
    {
        public static void WczytajKategorie(Telerik.WinControls.UI.RadDropDownList listaKategorii)
        {
            listaKategorii.Items.Clear();
            List<Typy> listaTypow = new List<Typy>();
            listaTypow = DBQueries.ZwrocTypy().ToList();
            for (int i = 0; i < listaTypow.Count; i++)
            {
                Telerik.WinControls.UI.RadListDataItem element = new Telerik.WinControls.UI.RadListDataItem();
                element.Text = listaTypow[i].Nazwa;
                listaKategorii.Items.Add(element);
            }
        }

        public static void PokazStanMagazynuWgTypu(int indeksTypu, Telerik.WinControls.UI.RadGridView dataGrid)
        {
            List<Sprzet> m_lista = new List<Sprzet>();
            int m_indeks = indeksTypu;
            //m_lista = DBQueries.zwrocSprzetWgTypu(m_indeks).ToList<Sprzet>();
            dataGrid.Rows.Clear();

            for (int i = 0; i < m_lista.Count; i++)
            {
                dataGrid.Rows.Add(m_lista[i].ID_Produktu, m_lista[i].Marka, m_lista[i].Model, m_lista[i].Opis);
                //dataGrid.Rows[i].Cells[1].Value = i;
                //dataGrid.Rows[i+1].Cells[1].Value = m_lista[i].Marka;
            }
        }
    }
}
