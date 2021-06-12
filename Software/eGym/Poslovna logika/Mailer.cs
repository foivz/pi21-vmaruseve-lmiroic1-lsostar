using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Pristup_podacima;

namespace Poslovna_logika
{
    public class Mailer
    {
        public static void PosaljiObavijestNaMail(Korisnik korisnik, string opis, string naslov)
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(Sesija.PrijavljeniKorisnik.email, Konfiguracija.VratiPostavku("mail.naslov"), Encoding.UTF8);
            mail.To.Add(new MailAddress(korisnik.email, korisnik.ime + " " + korisnik.prezime, Encoding.UTF8));
            mail.Subject = naslov;
            mail.SubjectEncoding = Encoding.UTF8;
            mail.IsBodyHtml = true;
            mail.Body = opis;
            mail.BodyEncoding = Encoding.UTF8;
            SmtpClient client = new SmtpClient();
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential(Konfiguracija.VratiPostavku("korisnik.email"), Konfiguracija.VratiPostavku("korisnik.lozinka"));
            client.Host = Konfiguracija.VratiPostavku("mail.smtp");
            client.Port = int.Parse(Konfiguracija.VratiPostavku("mail.port"));
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.Send(mail);
        }
    }
}
