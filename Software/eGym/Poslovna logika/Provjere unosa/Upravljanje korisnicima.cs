using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Pristup_podacima;

namespace Poslovna_logika.Provjere_unosa
{
    public class Upravljanje_korisnicima
    {
        
        public static bool ProvjeraPrijaveKorisnika(string korisnickoIme,string lozinka)
        {
          
            if (korisnickoIme != "" && lozinka != "")
                return true;
            else
                return false;
        }
       
        public static bool PrijaviKorisnika(string korisnickoIme,string lozinka)
        {
            if (ProvjeraPrijaveKorisnika(korisnickoIme, lozinka ))
            {
                Korisnik korisnikZaPrijavu = Pristup_podacima.Dohvaćanje_podataka.UpravljanjeKorisnicimaDAL.DohvatiKorisnika(korisnickoIme, lozinka);
                if (korisnikZaPrijavu != null)
                {
                    Sesija.PrijavljeniKorisnik = korisnikZaPrijavu;
                    return true;
                }
                return false;
            }
            else
                return false;
        }
        public static bool ProvjeraUnosaKodRegistracije(string kIme,string ime, string prezime, string brojMobitela, string email, string lozinka )
        {
           if(kIme!=""&&ime!=""&&prezime!=""&&brojMobitela!=""&&email!=""&& lozinka != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
