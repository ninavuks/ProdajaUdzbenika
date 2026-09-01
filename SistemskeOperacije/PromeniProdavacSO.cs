using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace SistemskeOperacije
{
    public class PromeniProdavacSO: BaseSO
    {
        private Prodavac prodavac;
        public PromeniProdavacSO(Prodavac prodavac) { this.prodavac = prodavac; }
        protected override void ExecuteConcreteOperation() => broker.Update(prodavac);

    }
}
