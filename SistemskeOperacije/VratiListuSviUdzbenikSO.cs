using DBBroker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace SistemskeOperacije
{
    public class VratiListuSviUdzbenikSO:BaseSO
    {
        public List<Udzbenik> Rezultat { get; set; }
        protected override void ExecuteConcreteOperation()
        {
            Rezultat = broker.GetAll(new Udzbenik()).Cast<Udzbenik>().ToList();
        }
    }
}
