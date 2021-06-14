using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pristup_podacima.Dohvaćanje_podataka
{
    public class UpravljanjeRezervacijamaDAL
    {
        public static void VratiTermine(Termin termin)
        {
            
            using (var db = new Entities())
            {
                Termin upit = (from t in db.Termins
                                where t.ID == termin.ID
                                select t).SingleOrDefault();
                db.Termins.Attach(upit);
                upit.broj_mjesta = upit.broj_mjesta - 1;
                db.SaveChanges();
            }
        }
        public static void Rezerviraj(RezervacijaTreninga rezervacija)
        {
            using (var db = new Entities())
            {
                db.RezervacijaTreningas.Add(rezervacija);
                db.SaveChanges();
            }

        }

        public static List<Korisnik> VratiTrenere()
        {
            List<Korisnik> treneri = new List<Korisnik>();

            using (var db = new Entities())
            {
                var upit = (from k in db.Korisniks
                             where k.uloga_id == 2
                             select k).ToList();
                treneri = upit;

            }
            return treneri;


        }
        public static List<Termin> VratiTerminePremaTreneru(Korisnik trener, DateTime zeljenidatum)
        {
            List<Termin> terminiIndividualnihTreninga = new List<Termin>();
            using (var db = new Entities())
            {
                var upit = (from t in db.Termins
                             where t.zaposlenik_korisnickoIme == trener.korisnickoIme && t.vrstaVjezbe_id == 1 && t.od.Month == zeljenidatum.Month && t.od.Day == zeljenidatum.Day && t.broj_mjesta >= 1
                             select t).ToList();
                terminiIndividualnihTreninga = upit;
            }
            return terminiIndividualnihTreninga;
        }
        public static List<Termin> VratiTerminePremaVrstiVjezbe(VrstaVjezbe vrstavjezbe, DateTime zeljenidatum)
        {
            List<Termin> terminiGrupnogTreninga = new List<Termin>();
            using (var db = new Entities())
            {
                var upit = (from t in db.Termins
                            where t.vrstaVjezbe_id == vrstavjezbe.ID && t.od.Month == zeljenidatum.Month && t.od.Day == zeljenidatum.Day && t.broj_mjesta >= 1
                            select t).ToList();
                terminiGrupnogTreninga = upit;
            }
            return terminiGrupnogTreninga;
        }
        public static List<VrstaVjezbe> VratiVrsteVjezbi()
        {
            List<VrstaVjezbe> listaVjezbi = new List<VrstaVjezbe>();
            using (var db = new Entities())
            {
                var upit = (from vv in db.VrstaVjezbes.Include("Termins")
                            select vv).ToList();
                listaVjezbi = upit;

            }
            return listaVjezbi;
        }
    
    }
}
