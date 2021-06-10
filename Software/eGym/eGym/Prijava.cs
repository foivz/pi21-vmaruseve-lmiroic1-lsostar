using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eGym
{
    public class Prijava
    {
        public string username { get; set; }
        public string password { get; set; }

        public static Korisnik DohvatiKorisnika(string username, string password)
        {
            Korisnik korisnik = null;
            List<Korisnik> SviKorisnici = null;


            using (var context = new Entities1())
            {
                SviKorisnici = context.Korisniks.ToList();
            }

            korisnik = SviKorisnici.Find(k => k.korisnickoIme == username && k.lozinka == password);

            return korisnik;
        }
    }
}
