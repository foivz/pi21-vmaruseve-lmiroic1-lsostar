using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pristup_podacima.Dohvaćanje_podataka
{
    public class UpravljanjeSuplementimaDAL
    {
        public static void AzuriranjeSuplementa(Suplement odabraniSuplement)
        {
            using (var db = new Entities())
            {
                Suplement noviSuplement = (from s in db.Suplements
                                           where s.ID == odabraniSuplement.ID
                                           select s).SingleOrDefault();
                db.Suplements.Attach(noviSuplement);
                noviSuplement.ID = odabraniSuplement.ID;
                noviSuplement.naziv = odabraniSuplement.naziv;
                noviSuplement.stanje = odabraniSuplement.stanje;
                noviSuplement.cijena = odabraniSuplement.cijena;
                db.SaveChanges();
            }

        }

        public static void UnosSuplementa(Suplement noviSuplement)
        {
            using (var db = new Entities())
            {
                db.Suplements.Add(noviSuplement);
                db.SaveChanges();

            }
        }

        public static void ObrisiSuplement (Suplement odabraniSuplement)
        {
            using (var db = new Entities())
            {
                var suplement = db.Suplements.Where(s => s.ID == odabraniSuplement.ID).FirstOrDefault();
                db.Suplements.Remove(suplement);
                db.SaveChanges();
            }
        }
    }
}
