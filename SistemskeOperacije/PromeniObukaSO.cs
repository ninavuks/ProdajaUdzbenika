using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace SistemskeOperacije
{
    public class PromeniObukaSO : BaseSO
    {
        private Obuka obuka;
        public PromeniObukaSO(Obuka obuka) { this.obuka = obuka; }
        protected override void ExecuteConcreteOperation() => broker.Update(obuka);
    
    }
}
