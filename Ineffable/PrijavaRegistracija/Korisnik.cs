using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BPModel;
namespace PrijavaRegistracija
{
    public class Korisnik
    {
        public  string ime { get; set; }
        public  string prezime { get; set; }
        public  int id { get; set; }
        public string ulogaNaziv { get; set; }
        public string spol { get; set; }
        public string korisnickoIme { get; set; }
        public string lozinka { get; set; }
        public string telefon { get; set; }
        public string adresa { get; set; }
        public string email { get; set; }
        public int uloga_id { get; set; }
        public int kupac_id { get; set; }
        public IntPtr avatar { get; set; }

        public Korisnik(BPModel.korisnik korisnik)
        {
            ime = korisnik.ime.ToString();
            prezime = korisnik.prezime.ToString();
            id = korisnik.korisnik_id;
            spol = korisnik.spol;
            korisnickoIme = korisnik.korisnicko_ime;
            lozinka = korisnik.lozinka;
            email = korisnik.email;
            adresa = korisnik.adresa;
            telefon = korisnik.telefon;
            uloga_id = korisnik.uloga_id;
            dohvatiUloguKorisnika(uloga_id);
            dohvatiKupacId();
        }
        void dohvatiUloguKorisnika(int ulogaID)
        {
            using (IneffableEntities bp = new IneffableEntities())
            {
                foreach (var item in bp.uloga)
                {
                    if (item.uloga_id == ulogaID)
                    {
                        ulogaNaziv = item.naziv;
                    }
                }
            }
        }
        public void dohvatiKupacId()
        {
            using (IneffableEntities bp = new IneffableEntities())
            {
                foreach (var item in bp.kupac)
                {
                    if (item.korisnik_id == this.id)
                    {
                        kupac_id = item.kupac_id;
                    }
                }
            }
        }
        public override string ToString()
        {
            return ime + " " + prezime;
        }
    }
}
