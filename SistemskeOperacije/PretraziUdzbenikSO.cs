using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace SistemskeOperacije
{
    public class PretraziUdzbenikSO: BaseSO
    {
        private Udzbenik kriterijum;
        public List<Udzbenik> Rezultat { get; set; }
        public PretraziUdzbenikSO(Udzbenik kriterijum) { this.kriterijum = kriterijum; }
        protected override void ExecuteConcreteOperation()
        {
            Rezultat = broker.GetByCriteria(kriterijum).Cast<Udzbenik>().ToList();
        }
    }
}
