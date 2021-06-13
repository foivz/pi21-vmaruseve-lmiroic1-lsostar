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
        public string HashirajLozinku(string input)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder(hash.Length * 2);
                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("x2"));

                }
                return sb.ToString();

            }
        }
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
