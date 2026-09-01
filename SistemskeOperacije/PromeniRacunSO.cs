using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Zajednicki.Domen;
namespace SistemskeOperacije
{
    public class PromeniRacunSO : BaseSO
    {
        private Racun racun;
        public PromeniRacunSO(Racun racun) { this.racun = racun; }
        protected override void ExecuteConcreteOperation() => broker.Update(racun);
    }
}
