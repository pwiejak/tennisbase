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
            List<Stan_Magazynowy> m_listaMagazynu = new List<Stan_Magazynowy>();
            int m_indeks = indeksTypu;
            m_listaMagazynu = DBQueries.zwrocStanMagazynowyWgTypu(m_indeks).ToList();
            //m_lista = DBQueries.zwrocSprzetWgTypu(m_indeks).ToList<Sprzet>();
            dataGrid.Rows.Clear();
            
            for (int i = 0; i < m_listaMagazynu.Count; i++)
            {
                if (m_listaMagazynu[i].Typ_Sprzedazy == 1)
                {
                    dataGrid.Rows.Add(m_listaMagazynu[i].Nr_Przedmiotu, m_listaMagazynu[i].ID_Produktu, m_listaMagazynu[i].Ilosc, m_listaMagazynu[i].Rozmiar,
                                    m_listaMagazynu[i].Cena, m_listaMagazynu[i].Kolor, "Tak");
                }
                else
                {
                    dataGrid.Rows.Add(m_listaMagazynu[i].Nr_Przedmiotu, m_listaMagazynu[i].ID_Produktu, m_listaMagazynu[i].Ilosc, m_listaMagazynu[i].Rozmiar,
                                    m_listaMagazynu[i].Cena, m_listaMagazynu[i].Kolor, "", "Tak");
                }
                //dataGrid.Rows[i].Cells[1].Value = i;
                //dataGrid.Rows[i+1].Cells[1].Value = m_lista[i].Marka;
            }
        }

        public static void PokazPrzedmiotWgID(int id, Telerik.WinControls.UI.RadGridView dataGrid)
        {
            int m_id = id;
            dataGrid.Rows.Clear();
            List<Stan_Magazynowy> szukanyPrzedmiot = new List<Stan_Magazynowy>();
            szukanyPrzedmiot = DBQueries.zwrocPrzedmiotWgID(m_id).ToList();
            if (szukanyPrzedmiot.Count == 0)
            {
                System.Windows.Forms.MessageBox.Show("Nie ma na stanie tego przedmiotu");
            }
            else
            {
                for (int i = 0; i < szukanyPrzedmiot.Count; i++)
                {
                    if (szukanyPrzedmiot[i].Typ_Sprzedazy == 1)
                    {
                        dataGrid.Rows.Add(szukanyPrzedmiot[i].Nr_Przedmiotu, szukanyPrzedmiot[i].ID_Produktu, szukanyPrzedmiot[i].Ilosc, szukanyPrzedmiot[i].Rozmiar,
                                        szukanyPrzedmiot[i].Cena, szukanyPrzedmiot[i].Kolor, "Tak");
                    }
                    else
                    {
                        dataGrid.Rows.Add(szukanyPrzedmiot[i].Nr_Przedmiotu, szukanyPrzedmiot[i].ID_Produktu, szukanyPrzedmiot[i].Ilosc, szukanyPrzedmiot[i].Rozmiar,
                                        szukanyPrzedmiot[i].Cena, szukanyPrzedmiot[i].Kolor, "", "Tak");
                    }
                }
            }
        }

    }
}
