using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;
namespace SistemskeOperacije
{
    public class PromeniKupacSO: BaseSO 
    {
        private Kupac kupac;
        public PromeniKupacSO(Kupac kupac) { this.kupac = kupac; }
        protected override void ExecuteConcreteOperation() => broker.Update(kupac);
    }
}
