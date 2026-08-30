using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace SistemskeOperacije
{
    public class KreirajUdzbenikSO : BaseSO
    {
            private Udzbenik udzbenik;
            public Udzbenik Rezultat { get; set; }
            public KreirajUdzbenikSO(Udzbenik udzbenik) { this.udzbenik = udzbenik; }
            protected override void ExecuteConcreteOperation()
            {
                udzbenik.Id = broker.Add(udzbenik);
                Rezultat = udzbenik;
            }
      
    }
}
