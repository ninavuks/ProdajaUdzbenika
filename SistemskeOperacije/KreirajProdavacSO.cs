using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace SistemskeOperacije
{
    public class KreirajProdavacSO: BaseSO 
    {
        private Prodavac prodavac;
        public Prodavac Rezultat { get; set; }
        public KreirajProdavacSO(Prodavac prodavac) { this.prodavac = prodavac; }
        protected override void ExecuteConcreteOperation()
        {
            prodavac.Id = broker.Add(prodavac);
            Rezultat = prodavac;
        }
    }
}
