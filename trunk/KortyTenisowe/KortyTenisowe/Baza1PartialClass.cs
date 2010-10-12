using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Security.Cryptography;

namespace KortyTenisowe
{
    public partial class Inzynierka1Entities
    {
        private static Inzynierka1Entities Entity;

        public static Inzynierka1Entities ENTITY
        {
            get
            {
                if (Entity == null)
                    Entity = new Inzynierka1Entities(ConnectionString);
                return Entity;
            }
        }

        private static string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["Inzynierka1Entities"].ConnectionString;
            }
        }
    }
}
