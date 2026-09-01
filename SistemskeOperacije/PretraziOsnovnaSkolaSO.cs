using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace SistemskeOperacije
{
    public class PretraziOsnovnaSkolaSO : BaseSO
    {
        private OsnovnaSkola kriterijum;
        public List<OsnovnaSkola> Rezultat { get; set; }
        public PretraziOsnovnaSkolaSO(OsnovnaSkola kriterijum) { this.kriterijum = kriterijum; }
        protected override void ExecuteConcreteOperation()
        {
            Rezultat = broker.GetByCriteria(kriterijum).Cast<OsnovnaSkola>().ToList();
        }
    }
}
