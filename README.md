# eGym

## Projektni tim

Ime i prezime | E-mail adresa (FOI) | JMBAG | Github korisničko ime
------------  | ------------------- | ----- | ---------------------
Valentina Maruševec | vmaruseve@foi.hr | 0016140449 | ValentinaMarusevec1
Lucija Miroić | lmiroic1@foi.hr | 0016136262 | LucijaMiroic
Lorena Šoštar | lsostar@foi.hr | 0016135309  | lsostar

## Opis domene
Ova bi aplikacija omogućila zaposlenicima evidentiranje članova, zaposlenika, smjena, suplemenata, naručivanje suplemenata, praćenje članarina, a svojim bi korisnicima omogućila rezerviranje individualnih i grupnih treninga.

## Specifikacija projekta

Oznaka | Naziv | Kratki opis | Odgovorni član tima
------ | ----- | ----------- | -------------------
F01 | Registracija | Za pristup aplikaciji potrebna je registracija korisnika (uloga u sustavu - obični korisnik, moderator i administrator) svojim osobnim podacima.| Lorena Šoštar
F02 | Login | Nakon registracije i nakon što administrator prihvati korisnika, svaki korisnik aplikacije može pristupiti aplikaciji pomoću svojih korisničkih podataka koje je unio prilikom registracije | Lorena Šoštar
F03 | Evidencija članova | Zaposlenik može pregledati popis svih članova, njihove profile (CRUD operacije), unijeti im određenu svotu novca koju član uplati u teretani. Tim novčanim iznosom korisnik može naručivati suplemente. | Lucija Miroić
F04 | Naručivanje suplemenata | Član, koji ima uplaćen iznos na svom profilu, može naručivati suplemente koje želi. Kada naruči suplement, ukupna cijena svih naručenih suplemenata oduzima se od iznosa na korisnikovom računu. | Valentina Maruševec
F05 | Evidencija zaposlenika | Zaposlenici mogu pregledati popis svih zaposlenika, njihove profile (CRUD operacije). Svaki zaposlenik ima svoju ulogu u teretani (individualni trener, grupni trener)| Lorena Šoštar
F06 | Evidencija suplemenata | CRUD operacije, član može naručiti određene suplemente. Također, svaki suplement ima svoju količinu te kada korisnik naruči određenu količinu tog suplementa, od trenutne količine suplementa se oduzima količina koju je korisnik naručio. | Lucija Miroić
F07 | Plaćanje članarina | Članovi odabiru koju članarinu žele platiti te ju plaćaju iznosom koji imaju na računu. Provjerava se ima li dovoljno novaca te ako ima plaća se i skida se svota iznosa. | Lorena Šoštar
F08 | Rezervacija individualnih treninga s biranjem trenera | Članovi teretane mogu pregledati i rezevirati željeni termin prema određenom treneru. Članovi na mail dobivaju obavijest o uspješnoj rezervaciji.  | Lucija Miroić
F09 | Rezervacija termina grupnih treninga prema vrsti vježbi | Članovi teretane mogu pregledati i rezervirati željeni termin prema određenim grupama koje su ponuđene prema vrstama vježbi. Članovi na mail dobivaju obavijest o uspješnoj rezervaciji. | Valentina Maruševec
F10 | Evidencija smjena | Unos smjeni za pojedinog zaposlenika (CRUD operacije) za lakšu organizaciju grupa | Valentina Maruševec
F11 | Izvješće | izvješće o prodanim suplementima i grafički prikaz broja prodanih suplemenata | Lucija Miroić
F12 | Evidencija termina | Zaposlenik ima mogućnost dodavati, ažurirati i brisati termine treninga. | Valentina Maruševec

## Tehnologije i oprema
Visual Studio 2019.
C#,
.NET Framework,
Datagrip, PostgreSQL,
Microsoft Project,
GitHub,
Visual Paradigm
