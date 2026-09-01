using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace SistemskeOperacije
{
    public class VratiListuSviProdavacSO: BaseSO
    {
        public List<Prodavac> Rezultat { get; set; }
        protected override void ExecuteConcreteOperation()
        {
            Rezultat = broker.GetAll(new Prodavac()).Cast<Prodavac>().ToList();
        }
    
    }
}
