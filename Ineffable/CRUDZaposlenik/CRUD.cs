using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPModel;
using PrijavaRegistracija;
namespace CRUDZaposlenik
{
    class CRUD
    {
        Korisnik zaposlenik;
        List<Korisnik> zaposlenici;
        public List<Korisnik> dohvatiZaposlenike()
        {
            using (IneffableEntities bp = new IneffableEntities())
            {
                zaposlenici = null;
                zaposlenici = new List<Korisnik>();
                foreach (var item in bp.korisnik)
                {
                    if (item.uloga_id == 1 || item.uloga_id == 2)
                    {
                        zaposlenik = new Korisnik(item);
                        zaposlenici.Add(zaposlenik);
                    }
                }
            }
            return zaposlenici;
        }
        public void spremiZaposlenika(Korisnik zaposlenik)
        {
            using (IneffableEntities bp = new IneffableEntities())
            {
                var korisnik = bp.korisnik.Find(zaposlenik.id);

                korisnik.ime = zaposlenik.ime;
                korisnik.prezime = zaposlenik.prezime;
                korisnik.korisnik_id = zaposlenik.id;
                korisnik.spol = zaposlenik.spol;
                korisnik.korisnicko_ime = zaposlenik.korisnickoIme;
                korisnik.lozinka = zaposlenik.lozinka;
                korisnik.email = zaposlenik.email;
                korisnik.adresa = zaposlenik.adresa;
                korisnik.telefon = zaposlenik.telefon;
                korisnik.uloga_id = zaposlenik.uloga_id;
                
                bp.SaveChanges();
            }
        }
        public void izbrisiZaposlenika(Korisnik zaposlenik)
        {
            using (IneffableEntities bp = new IneffableEntities())
            {
                var korisnik = bp.korisnik.Find(zaposlenik.id);
                bp.korisnik.Remove(korisnik);
                bp.SaveChanges();
            }
        }
        private int dohvatiIDUloge(string uloga)
        {
            using (IneffableEntities bp = new IneffableEntities())
            {
                int uloga_id;   
                foreach (var item in bp.uloga)
                {
                    if (item.naziv == uloga)
                    {
                        return uloga_id = item.uloga_id;
                    }
                }
            }
            return -1;
        }
    }
}
