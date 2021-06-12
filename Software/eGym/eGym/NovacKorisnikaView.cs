using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pristup_podacima;

namespace eGym
{
    public class NovacKorisnikaView
    {
        public int Id { get; set; }
        public decimal? StanjeNaRacunu { get; set; }
        public Korisnik Korisnik { get; set; }
    }
}
