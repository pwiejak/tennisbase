using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KortyTenisowe
{
    class TabWypozyczalnia
    {
        public static void PokazWypozyczenia(Telerik.WinControls.UI.RadGridView dataGrid)
        {
            List<Wypozyczone> m_lista = new List<Wypozyczone>();
            m_lista = DBQueries.zwrocWypozyczenia().ToList<Wypozyczone>();
            dataGrid.Rows.Clear();

            for (int i = 0; i < m_lista.Count; i++)
            {
                if (m_lista[i].Wypozyczono)
                {
                    dataGrid.Rows.Add(m_lista[i].ID_Wypozyczenia, m_lista[i].ID_Przedmiotu,
                                    m_lista[i].Id_Klienta, m_lista[i].Data_Rozpoczecia.Date, m_lista[i].Godzina_Rozpoczecia, 
                                    m_lista[i].Data_Zakonczenia.Date, m_lista[i].Godzina_Zakonczenia, "Tak");
                }
                else
                {
                    dataGrid.Rows.Add(m_lista[i].ID_Wypozyczenia, m_lista[i].ID_Przedmiotu, m_lista[i].Id_Klienta,
                                        m_lista[i].Data_Rozpoczecia.Date, m_lista[i].Godzina_Rozpoczecia, m_lista[i].Data_Zakonczenia.Date,
                                        m_lista[i].Godzina_Zakonczenia, "Nie");
                }
                    //dataGrid.Rows[i].Cells[1].Value = i;
                //dataGrid.Rows[i+1].Cells[1].Value = m_lista[i].Marka;
            }
        }

        public static void PokazStany(Telerik.WinControls.UI.RadDropDownList listaStanow)
        {
            listaStanow.Items.Clear();
            Telerik.WinControls.UI.RadListDataItem element = new Telerik.WinControls.UI.RadListDataItem();
            element.Text = "Zamowione";
            listaStanow.Items.Add(element);

            Telerik.WinControls.UI.RadListDataItem element1 = new Telerik.WinControls.UI.RadListDataItem();
            element1.Text = "Odebrane";
            listaStanow.Items.Add(element1);

            Telerik.WinControls.UI.RadListDataItem element2 = new Telerik.WinControls.UI.RadListDataItem();
            element2.Text = "Zwrocone";
            listaStanow.Items.Add(element2);

            Telerik.WinControls.UI.RadListDataItem element3 = new Telerik.WinControls.UI.RadListDataItem();
            element3.Text = "Wszystkie";
            listaStanow.Items.Add(element3);
        }

        public void PokazDlaDanegoStanu(Telerik.WinControls.UI.RadGridView dataGrid, int stan)
        {
            List<Wypozyczone> m_lista = new List<Wypozyczone>();
            m_lista = DBQueries.zwrocWypozyczenia().ToList<Wypozyczone>();
            dataGrid.Rows.Clear();

            for (int i = 0; i < m_lista.Count; i++)
            {
                if (stan == 1)
                {
                    if ((m_lista[i].Wypozyczono == false))
                    {
                        dataGrid.Rows.Add(m_lista[i].ID_Wypozyczenia, m_lista[i].ID_Przedmiotu,
                                    m_lista[i].Id_Klienta, m_lista[i].Data_Rozpoczecia.Date, m_lista[i].Godzina_Rozpoczecia,
                                    m_lista[i].Data_Zakonczenia.Date, m_lista[i].Godzina_Zakonczenia, "Nie");
                    }
                }
                else if (stan == 2)
                {
                    if ((m_lista[i].Wypozyczono == true) && (m_lista[i].Zwrocono == null))
                    {
                        dataGrid.Rows.Add(m_lista[i].ID_Wypozyczenia, m_lista[i].ID_Przedmiotu,
                                    m_lista[i].Id_Klienta, m_lista[i].Data_Rozpoczecia.Date, m_lista[i].Godzina_Rozpoczecia,
                                    m_lista[i].Data_Zakonczenia.Date, m_lista[i].Godzina_Zakonczenia, "Tak", "Nie");
                    }
                    else 
                        if ((m_lista[i].Wypozyczono == true) && (m_lista[i].Zwrocono == true))
                        {
                            dataGrid.Rows.Add(m_lista[i].ID_Wypozyczenia, m_lista[i].ID_Przedmiotu,
                                        m_lista[i].Id_Klienta, m_lista[i].Data_Rozpoczecia.Date, m_lista[i].Godzina_Rozpoczecia,
                                        m_lista[i].Data_Zakonczenia.Date, m_lista[i].Godzina_Zakonczenia, "Tak", "Tak");
                        }
                }
                else if (stan == 3)
                {
                    if ((m_lista[i].Wypozyczono == true) && (m_lista[i].Zwrocono == true))
                    {
                        dataGrid.Rows.Add(m_lista[i].ID_Wypozyczenia, m_lista[i].ID_Przedmiotu,
                                    m_lista[i].Id_Klienta, m_lista[i].Data_Rozpoczecia.Date, m_lista[i].Godzina_Rozpoczecia,
                                    m_lista[i].Data_Zakonczenia.Date, m_lista[i].Godzina_Zakonczenia, "Tak", "Tak");
                    }
                }
                else
                {
                    if ((m_lista[i].Wypozyczono == false))
                    {
                        dataGrid.Rows.Add(m_lista[i].ID_Wypozyczenia, m_lista[i].ID_Przedmiotu,
                                    m_lista[i].Id_Klienta, m_lista[i].Data_Rozpoczecia.Date, m_lista[i].Godzina_Rozpoczecia,
                                    m_lista[i].Data_Zakonczenia.Date, m_lista[i].Godzina_Zakonczenia, "Nie");
                    }
                    else if ((m_lista[i].Wypozyczono == true) && (m_lista[i].Zwrocono == null))
                    {
                        dataGrid.Rows.Add(m_lista[i].ID_Wypozyczenia, m_lista[i].ID_Przedmiotu,
                                    m_lista[i].Id_Klienta, m_lista[i].Data_Rozpoczecia.Date, m_lista[i].Godzina_Rozpoczecia,
                                    m_lista[i].Data_Zakonczenia.Date, m_lista[i].Godzina_Zakonczenia, "Tak", "Nie");
                    }
                    else if ((m_lista[i].Wypozyczono == true) && (m_lista[i].Zwrocono == true))
                    {
                        dataGrid.Rows.Add(m_lista[i].ID_Wypozyczenia, m_lista[i].ID_Przedmiotu,
                                    m_lista[i].Id_Klienta, m_lista[i].Data_Rozpoczecia.Date, m_lista[i].Godzina_Rozpoczecia,
                                    m_lista[i].Data_Zakonczenia.Date, m_lista[i].Godzina_Zakonczenia, "Tak", "Tak");
                    }
                    
                }
            }

        }

    }
}
