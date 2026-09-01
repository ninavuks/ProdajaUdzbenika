using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace SistemskeOperacije
{
    public class PromeniOsnovnaSkolaSO : BaseSO
    {
        private OsnovnaSkola skola;
        public PromeniOsnovnaSkolaSO(OsnovnaSkola skola) { this.skola = skola; }
        protected override void ExecuteConcreteOperation() => broker.Update(skola);
        
    }
}

   