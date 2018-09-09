using BPModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrijavaRegistracija
{
    public class Autentifikator
    {
        public bool registrirajKorisnika(string ime, string prezime, string email, string korIme, string lozinka, string adresa, string telefon, string spol, int uloga)
        {
            bool ispravno = true;
            using (IneffableEntities bp = new IneffableEntities())
            {
                foreach (var item in bp.korisnik)
                {
                    if (item.korisnicko_ime == korIme)
                    {
                        return !ispravno;
                    }
                }
                if (ispravno)
                {
                    korisnik korisnik = new korisnik()
                    {
                        ime = ime,
                        prezime = prezime,
                        korisnicko_ime = korIme,
                        lozinka = lozinka,
                        email = email,
                        adresa = adresa,
                        telefon = telefon,
                        uloga_id = uloga,
                        spol = spol
                    };
                    if (korisnik.uloga_id == 3)
                    {
                        kupac kupac = new kupac()
                        {
                            ime = ime,
                            prezime = prezime,
                            spol = spol,
                            korisnik_id = korisnik.korisnik_id
                        };
                        bp.kupac.Add(kupac);
                    }
                    bp.korisnik.Add(korisnik);
                    bp.SaveChanges();
                }
            }
            return ispravno;
        }

        public static Korisnik korisnik { get; set; }

        public string prijaviKorisnika(string korIme, string lozinka)
        {
            string korRegistriran = "korime";
            using (IneffableEntities bp = new IneffableEntities())
            {
                foreach (var item in bp.korisnik)
                {
                    if (item.korisnicko_ime == korIme)
                    {
                        if (item.lozinka == lozinka)
                        {
                            korRegistriran = "";
                            korisnik = new Korisnik(item);
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

        public static Korisnik dohvatiPrijavljenogKorisnika()
        { 
            return korisnik;
        }
    }
}
