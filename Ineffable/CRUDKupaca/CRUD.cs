using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrijavaRegistracija;
using BPModel;
namespace CRUDKupaca
{
    public class CRUD
    {
        public void azurirajKupca(Korisnik kupac)
        {
            using (IneffableEntities bp = new IneffableEntities())
            {
                var korisnik = bp.korisnik.Find(kupac.id);

                korisnik.ime = kupac.ime;
                korisnik.prezime = kupac.prezime;
                korisnik.korisnik_id = kupac.id;
                korisnik.spol = kupac.spol;
                korisnik.korisnicko_ime = kupac.korisnickoIme;
                korisnik.lozinka = kupac.lozinka;
                korisnik.email = kupac.email;
                korisnik.adresa = kupac.adresa;
                korisnik.telefon = kupac.telefon;
                azurirajKupce(kupac);

                bp.SaveChanges();
            }
        }

        public Korisnik dohvatiKupca(int kupac_id)
        {
            Korisnik kupac = null;
            using(IneffableEntities bp = new IneffableEntities())
            {
                foreach (var korisnik in bp.korisnik)
                {
                    if (korisnik.korisnik_id == kupac_id)
                    {
                        kupac = new Korisnik(korisnik);
                    }
                }
            }
            return kupac;
        }

        private void azurirajKupce(Korisnik kupac)
        {
            using (IneffableEntities bp = new IneffableEntities())
            {
                var korisnik = bp.kupac.Find(kupac.kupac_id); 

                korisnik.ime = kupac.ime;
                korisnik.prezime = kupac.prezime;
                korisnik.spol = kupac.spol;
                bp.SaveChanges();
            }
        }
        public void izbrisiKupca(int korisnikId)
        {
            using (IneffableEntities bp = new IneffableEntities())
            {
                foreach (var item in bp.korisnik)
                {

                    if (item.korisnik_id == korisnikId)
                    {
                        bp.korisnik.Remove(item);
                    }
                }
                foreach (var item in bp.kupac)
                {
                    if (item.korisnik_id == korisnikId)
                    {
                        bp.kupac.Remove(item);
                    }
                }
                bp.SaveChanges();
            }
        }    
    }
}
