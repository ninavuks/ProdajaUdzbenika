using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Zajednicki.Domen;
namespace SistemskeOperacije
{
    public class VratiListuSviRacunSO : BaseSO
    {
        public List<Racun> Rezultat { get; set; }
        protected override void ExecuteConcreteOperation()
        {
            Rezultat = broker.GetAll(new Racun()).Cast<Racun>().ToList();
        }
    }
}
