using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KortyTenisowe
{
    public class DBQueries
    {
        public bool Logowanie(string Login, string haslo)
        {
            bool Poprawny = false;
            try
            {
                Uzytkownicy_Systemu user = (from Uzytkownicy_Systemu users in Inzynierka1Entities.ENTITY.Uzytkownicy_Systemu where String.Compare(Login, users.Login, true) == 0 select users).FirstOrDefault(); 
                if(String.Compare(user.Haslo, haslo, true) == 0)
                    Poprawny = true;
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Błąd ! ");
            }
            
            return Poprawny;
        }
    }
}
