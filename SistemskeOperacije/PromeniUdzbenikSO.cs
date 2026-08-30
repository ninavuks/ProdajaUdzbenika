using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace SistemskeOperacije
{
    public class PromeniUdzbenikSO: BaseSO
    {
        private Udzbenik udzbenik;
        public PromeniUdzbenikSO(Udzbenik udzbenik) { this.udzbenik = udzbenik; }
        protected override void ExecuteConcreteOperation()
        {
            broker.Update(udzbenik);
        }
    }
}
