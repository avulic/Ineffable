using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrijavaRegistracija;
using BPModel;
namespace Servisi
{
    public class Log
    {
        public double ukupnaCijena { get; set; }
        public Dictionary<string, string> opis = new Dictionary<string, string>();
        public Dictionary<string, double> cijenaPromjene = new Dictionary<string, double>();
        public Log(int servisId)
        {
            using (IneffableEntities bp = new IneffableEntities())
            {
                foreach (var item in bp.servis_log)
                {
                    if (item.servis_id == servisId)
                    {
                        opis.Add(item.status, item.opis_promjene);
                        cijenaPromjene.Add(item.status, (double)item.cijena_promjene);
                    }
                }
            }
            izracunajUkupnaCijena();
        }
        private void izracunajUkupnaCijena()
        {
            foreach (var item in cijenaPromjene)
            {
                ukupnaCijena += item.Value;
            }
        }
    }
}
