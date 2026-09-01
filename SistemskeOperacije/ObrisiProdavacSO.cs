using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace SistemskeOperacije
{
    public class ObrisiProdavacSO: BaseSO
    {
        private Prodavac prodavac;
        public ObrisiProdavacSO(Prodavac prodavac) { this.prodavac = prodavac; }
        protected override void ExecuteConcreteOperation() => broker.Delete(prodavac);
    }
}
