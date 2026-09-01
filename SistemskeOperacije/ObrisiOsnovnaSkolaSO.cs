using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace SistemskeOperacije
{
    public class ObrisiOsnovnaSkolaSO : BaseSO
    {
        private OsnovnaSkola skola;
        public ObrisiOsnovnaSkolaSO(OsnovnaSkola skola) { this.skola = skola; }
        protected override void ExecuteConcreteOperation() => broker.Delete(skola);
    }
}
