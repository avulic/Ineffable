using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrijavaRegistracija;
using BPModel;
namespace Servisi
{
    public class Servis
    {
        Korisnik korisnik;
        public Log log { get; set; }
        public string uredjaj { get; set; }
        public int servisId { get; set; }
        public string oznaka { get; set; }
        public string trenutnaFaza { get; set; }
        public string status { get; set; }
        public Servis(Korisnik korisnik, string uredjaj)
        {
            this.uredjaj = uredjaj;
            this.korisnik = korisnik;
            dohvatiPodatkeServisa();
        }
        private void dohvatiPodatkeServisa()
        {
            using (IneffableEntities bp = new IneffableEntities())
            {
                foreach (var item in bp.radni_nalog_servisa)
                {
                    if (item.osoba_id == korisnik.kupac_id && uredjaj == item.uredjaj)
                    {
                        uredjaj = item.uredjaj;
                        servisId = item.servis_id;
                        oznaka = item.oznaka;
                        trenutnaFaza = item.status;
                        status = item.status;
                        log = new Log(servisId);
                        break;
                    }
                }
            }
        }
        
    }
}
