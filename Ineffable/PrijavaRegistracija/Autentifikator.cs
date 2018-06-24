using BPModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrijavaRegistracija
{
    class Autentifikator
    {
        public bool registrirajKorisnika(string ime, string prezime, string email, string korIme, string lozinka, string adresa, string telefon)
        {
            bool ispravno = false;
            using (IneffableEntities bp = new IneffableEntities())
            {
                foreach (var item in bp.korisnik)
                {
                    if (item.korisnicko_ime == korIme)
                    {
                        return ispravno;
                    }
                    
                }
                korisnik korisnik = new korisnik()
                {
                    ime = ime,
                    prezime = prezime,
                    korisnicko_ime = ime,
                    lozinka = lozinka,
                    email = email,
                    adresa = adresa,
                    telefon = telefon,
                    uloga_id = 1
                };
                bp.korisnik.Add(korisnik);
                bp.SaveChanges();
                
                ispravno = true;    
            }
            return ispravno;
        }
        public string prijaviKorisnika(string korIme, string lozinka)
        {
            string korRegistriran = "korime";
            using (IneffableEntities bp = new IneffableEntities())
            {
                foreach (var korisnik in bp.korisnik)
                {
                    if (korisnik.korisnicko_ime == korIme)
                    {
                        if (korisnik.lozinka == lozinka)
                        {
                            korRegistriran = "";
                        }
                        else
                        {
                            korRegistriran = "lozinka";
                        }
                    }
                }
            }
            return korRegistriran;
        }
    }
}
