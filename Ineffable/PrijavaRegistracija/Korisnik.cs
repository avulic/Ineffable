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
        public  string uloga { get; set; }

        public Korisnik(BPModel.korisnik korisnik)
        {
            ime = korisnik.ime.ToString();
            prezime = korisnik.prezime.ToString();
            id = korisnik.korisnik_id;
            dohvatiUloguKorisnika(korisnik.uloga_id);
        }
        void dohvatiUloguKorisnika(int ulogaID)
        {
            using (IneffableEntities bp = new IneffableEntities())
            {
                foreach (var item in bp.uloga)
                {
                    if (item.uloga_id == ulogaID)
                    {
                        uloga = item.naziv;
                    }
                }
            }
        }
    }
}
