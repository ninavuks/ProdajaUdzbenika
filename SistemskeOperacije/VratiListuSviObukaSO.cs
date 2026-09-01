using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace SistemskeOperacije
{
    public class VratiListuSviObukaSO : BaseSO
    {
        public List<Obuka> Rezultat { get; set; }
        protected override void ExecuteConcreteOperation()
        {
            Rezultat = broker.GetAll(new Obuka()).Cast<Obuka>().ToList();
        }
    
    }
}
