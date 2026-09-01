using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace SistemskeOperacije
{
    public class KreirajKupacSO : BaseSO
    {
        private Kupac kupac;
        public Kupac Rezultat { get; set; }
        public KreirajKupacSO(Kupac kupac) { this.kupac = kupac; }
        protected override void ExecuteConcreteOperation()
        {
            kupac.Id = broker.Add(kupac);
            Rezultat = kupac;
        }
    }
}