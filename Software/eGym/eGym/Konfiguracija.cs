using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eGym
{
    public class Konfiguracija
    {
        public static string VratiPostavku(string kljuc)
        {
            return ConfigurationManager.AppSettings.Get(kljuc);
        }
    }
}
