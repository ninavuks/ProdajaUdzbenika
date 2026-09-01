using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace SistemskeOperacije
{
    public class VratiListuSviOsnovnaSkolaSO : BaseSO
    {
        public List<OsnovnaSkola> Rezultat { get; set; }
        protected override void ExecuteConcreteOperation()
        {
            Rezultat = broker.GetAll(new OsnovnaSkola()).Cast<OsnovnaSkola>().ToList();
        }
    }
}
