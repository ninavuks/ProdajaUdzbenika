using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Zajednicki.Domen;
namespace SistemskeOperacije
{
    public class PretraziRacunSO : BaseSO
    {
        private Racun kriterijum;
        public List<Racun> Rezultat { get; set; }
        public PretraziRacunSO(Racun kriterijum) { this.kriterijum = kriterijum; }
        protected override void ExecuteConcreteOperation()
        {
            Rezultat = broker.GetByCriteria(kriterijum).Cast<Racun>().ToList();
        }
    }
}
