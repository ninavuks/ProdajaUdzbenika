using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace SistemskeOperacije
{
    public class KreirajObukaSO : BaseSO 
    {
        private Obuka obuka;
        public Obuka Rezultat { get; set; }
        public KreirajObukaSO(Obuka obuka) { this.obuka = obuka; }
        protected override void ExecuteConcreteOperation()
        {
            obuka.Id = broker.Add(obuka);
            Rezultat = obuka;
        }

    }
}
