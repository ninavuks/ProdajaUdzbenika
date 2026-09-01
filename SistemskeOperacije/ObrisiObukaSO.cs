using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace SistemskeOperacije
{
    public class ObrisiObukaSO : BaseSO
    {
        private Obuka obuka;
        public ObrisiObukaSO(Obuka obuka) { this.obuka = obuka; }
        protected override void ExecuteConcreteOperation() => broker.Delete(obuka);
    
    }
}
