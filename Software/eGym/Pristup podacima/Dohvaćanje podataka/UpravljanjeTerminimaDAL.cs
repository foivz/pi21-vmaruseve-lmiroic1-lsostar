using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pristup_podacima.Dohvaćanje_podataka
{
    public class UpravljanjeTerminimaDAL
    {
        public static void UnosTermina(Termin  noviTermin)
        {
            using (var db = new Entities())
            {
                db.Termins.Add(noviTermin);
                db.SaveChanges();

            }
        }
        public static void ObrisiTermin (Termin odabraniTermin)
        {
            using (var db = new Entities())
            {
                var termin = db.Termins.Where(s => s.ID == odabraniTermin.ID).FirstOrDefault();
                db.Termins.Remove(termin);
                db.SaveChanges();
            }
        }
    }
}
