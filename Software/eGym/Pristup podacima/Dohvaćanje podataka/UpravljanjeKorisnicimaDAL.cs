using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Pristup_podacima.Dohvaćanje_podataka
{
    public class UpravljanjeKorisnicimaDAL
    {

        public static Korisnik DohvatiKorisnika(string korisničkoIme, string lozinka)
        {
            Korisnik korisnikZaPrijavu = new Korisnik();
            using (var db=new Entities())
            {
                Korisnik korisnik = (from k in db.Korisniks
                                     where k.lozinka == lozinka && k.korisnickoIme == korisničkoIme
                                     select k).FirstOrDefault();
                korisnikZaPrijavu = korisnik;
            }
            return korisnikZaPrijavu;

        }
        public static void UnosKorisnika(Korisnik noviKorisnik)
        {
            using (var db=new Entities())
            {
                db.Korisniks.Add(noviKorisnik);
                db.SaveChanges();
            }

        }
    
    
        public static void AzuriranjeClana(Korisnik odabraniClan)
        {
            using (var db = new Entities())
            {
                Korisnik noviKorisnik = (from k in db.Korisniks
                                         where k.korisnickoIme == odabraniClan.korisnickoIme
                                         select k).SingleOrDefault();
                db.Korisniks.Attach(noviKorisnik);
                noviKorisnik.korisnickoIme = odabraniClan.korisnickoIme;
                noviKorisnik.ime = odabraniClan.ime;
                noviKorisnik.prezime = odabraniClan.prezime;
                noviKorisnik.email = odabraniClan.email;
                noviKorisnik.brojtelefona = odabraniClan.brojtelefona;
                noviKorisnik.lozinka = odabraniClan.lozinka;
                noviKorisnik.stanjeNaRacunu = odabraniClan.stanjeNaRacunu;
                db.SaveChanges();
            }

        }
       
        public static void AzuriranjeZaposlenika(Korisnik odabraniZaposlenik)
        {
            using (var db = new Entities())
            {
                Korisnik noviKorisnik = (from k in db.Korisniks
                                         where k.korisnickoIme == odabraniZaposlenik.korisnickoIme
                                         select k).SingleOrDefault();
                db.Korisniks.Attach(noviKorisnik);
                noviKorisnik.korisnickoIme = odabraniZaposlenik.korisnickoIme;
                noviKorisnik.ime = odabraniZaposlenik.ime;
                noviKorisnik.prezime = odabraniZaposlenik.prezime;
                noviKorisnik.email = odabraniZaposlenik.email;
                noviKorisnik.brojtelefona = odabraniZaposlenik.brojtelefona;
                noviKorisnik.lozinka = odabraniZaposlenik.lozinka;
                noviKorisnik.stanjeNaRacunu = odabraniZaposlenik.stanjeNaRacunu;
                db.SaveChanges();
            }

        }

        public static void UnosPrveClanarine(Clanarina clanarina)
        {
            using (var db = new Entities())
            {
                db.Clanarinas.Add(clanarina);
                db.SaveChanges();
            }

        }

        public static void ObrisiClana(Korisnik odabraniClan)
        {
            using (var db = new Entities())
            {
                var korisnik = db.Korisniks.Where(t => t.korisnickoIme == odabraniClan.korisnickoIme).FirstOrDefault();
                db.Korisniks.Remove(korisnik);
                db.SaveChanges();
            }
        }

      

        public static void UnosZaposlenika(Korisnik noviKorisnik)
        {
            using (var db = new Entities())
            {
                db.Korisniks.Add(noviKorisnik);
                db.SaveChanges();
            }

        }

        public static void ObrisiZaposlenika(Korisnik odabraniClan)
        {
            using (var db = new Entities())
            {
                var korisnik = db.Korisniks.Where(t => t.korisnickoIme == odabraniClan.korisnickoIme).FirstOrDefault();
                db.Korisniks.Remove(korisnik);
                db.SaveChanges();
            }
        }



    }
}
