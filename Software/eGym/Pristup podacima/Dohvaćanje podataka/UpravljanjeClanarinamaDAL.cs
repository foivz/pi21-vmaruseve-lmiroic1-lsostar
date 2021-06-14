using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pristup_podacima.Dohvaćanje_podataka
{
    public class UpravljanjeClanarinamaDAL
    {
        public static bool VratiVrijemePlacanja(Korisnik korisnik)
        {
            List<Clanarina> clanarina = new List<Clanarina>();
            bool clanarinaPlacena = false;
            using (var db = new Entities())
            {
                var upit = from c in db.Clanarinas.Include("Korisnik")
                            where c.korisnik_korisnickoIme == korisnik.korisnickoIme
                            orderby c.ID
                            select c;

                foreach (var item in upit)
                {
                    clanarina.Add(item);
                }

                DateTime vrijediDo = clanarina.Last().vrijedi_do;

                if (vrijediDo > DateTime.Now)
                {
                    clanarinaPlacena = true;
                }
            }
            return clanarinaPlacena;
        }
        public static void PlatiClanarinu(Clanarina novaClanarina)
        {
            using (var db = new Entities())
            {
                db.Clanarinas.Add(novaClanarina);
                db.SaveChanges();
            }
        }
       public static string PrikaziStanjeNaRacunu(Korisnik odabraniKorisnik)
        {
            string stanje = "";
            using (var db = new Entities())
            {
                var upit = from k in db.Korisniks.Include("Clanarinas").Include("UlogaUTeretani").Include("NaruceniSuplements").Include("RezervacijaTreningas").Include("SmjenaZaposlenikas").Include("Termins")
                           where k.korisnickoIme == odabraniKorisnik.korisnickoIme
                           select k.stanjeNaRacunu;
                stanje = upit.FirstOrDefault().ToString();
            }
            return stanje;
            
        }
        public static List<VrstaClanarine> DohvatiVrsteClanarine()
        {
            List<VrstaClanarine> sveClanarine = new List<VrstaClanarine>();

            using (var db = new Entities())
            {
                var upit = from vc in db.VrstaClanarines.Include("Clanarinas")
                            select vc;
                sveClanarine = upit.ToList();

            }
            return sveClanarine;

            
        }
    }
}
