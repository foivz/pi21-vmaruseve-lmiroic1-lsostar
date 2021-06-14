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
            
            using (var context = new Entities())
            {
                Termin query = (from t in context.Termins
                                where t.ID == termin.ID
                                select t).SingleOrDefault();
                context.Termins.Attach(query);
                query.broj_mjesta = query.broj_mjesta - 1;
                context.SaveChanges();
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

            using (var context = new Entities())
            {
                var query = (from k in context.Korisniks
                             where k.uloga_id == 2
                             select k).ToList();
                treneri = query;

            }
            return treneri;


        }
        public static List<Termin> VratiTerminePremaTreneru(Korisnik trener, DateTime zeljenidatum)
        {
            List<Termin> terminiIndividualnihTreninga = new List<Termin>();
            using (var context = new Entities())
            {
                var query = (from t in context.Termins
                             where t.zaposlenik_korisnickoIme == trener.korisnickoIme && t.vrstaVjezbe_id == 1 && t.od.Month == zeljenidatum.Month && t.od.Day == zeljenidatum.Day && t.broj_mjesta >= 1
                             select t).ToList();
                terminiIndividualnihTreninga = query;
            }
            return terminiIndividualnihTreninga;
        }
        public static List<Termin> VratiTerminePremaVrstiVjezbe(VrstaVjezbe vrstavjezbe, DateTime zeljenidatum)
        {
            List<Termin> terminiGrupnogTreninga = new List<Termin>();
            using (var context = new Entities())
            {
                var upit = (from t in context.Termins
                            where t.vrstaVjezbe_id == vrstavjezbe.ID && t.od.Month == zeljenidatum.Month && t.od.Day == zeljenidatum.Day && t.broj_mjesta >= 1
                            select t).ToList();
                terminiGrupnogTreninga = upit;
            }
            return terminiGrupnogTreninga;
        }
        public static List<VrstaVjezbe> VratiVrsteVjezbi()
        {
            List<VrstaVjezbe> listaVjezbi = new List<VrstaVjezbe>();
            using (var context = new Entities())
            {
                var upit = (from vv in context.VrstaVjezbes.Include("Termins")
                            select vv).ToList();
                listaVjezbi = upit;

            }
            return listaVjezbi;
        }
    
    }
}
