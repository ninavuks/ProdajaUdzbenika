using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace SistemskeOperacije
{
    public class VratiListuSviKupacSO : BaseSO
    {
        public List<Kupac> Rezultat { get; set; }
        protected override void ExecuteConcreteOperation()
        {
            Rezultat = broker.GetAll(new Kupac()).Cast<Kupac>().ToList();
        }
    }
}
