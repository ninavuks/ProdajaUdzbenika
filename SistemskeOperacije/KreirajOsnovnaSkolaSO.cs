using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace SistemskeOperacije
{
    public class KreirajOsnovnaSkolaSO : BaseSO
    {
        private OsnovnaSkola skola;
        public OsnovnaSkola Rezultat { get; set; }
        public KreirajOsnovnaSkolaSO(OsnovnaSkola skola) { this.skola = skola; }
        protected override void ExecuteConcreteOperation()
        {
            skola.Id = broker.Add(skola);
            Rezultat = skola;
        }
    }
}
