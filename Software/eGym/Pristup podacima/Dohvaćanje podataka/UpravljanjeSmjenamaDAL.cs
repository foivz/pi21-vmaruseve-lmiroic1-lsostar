using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pristup_podacima.Dohvaćanje_podataka
{
    public class UpravljanjeSmjenamaDAL
    {
        public static void UnosSmjene(SmjenaZaposlenika novaSmjena)
        {
            using (var db = new Entities())
            {
                db.SmjenaZaposlenikas.Add(novaSmjena);
                db.SaveChanges();
            }

        }
        public static void ObrisiSmjenuKorisnika(SmjenaZaposlenika odabranaSmjena)
        {
            using (var db = new Entities())
            {
                var smjena = db.SmjenaZaposlenikas.Where(s => s.smjena_id == odabranaSmjena.smjena_id).FirstOrDefault();
                db.SmjenaZaposlenikas.Remove(smjena);
                db.SaveChanges();
            }
        }
    }
}
