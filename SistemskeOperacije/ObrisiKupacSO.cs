using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace SistemskeOperacije
{
    public class ObrisiKupacSO: BaseSO 
    {
        private Kupac kupac;
        public ObrisiKupacSO(Kupac kupac) { this.kupac = kupac; }
        protected override void ExecuteConcreteOperation() => broker.Delete(kupac);
    }
}
