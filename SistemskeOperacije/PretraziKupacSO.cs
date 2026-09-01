using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;
namespace SistemskeOperacije
{
    public class PretraziKupacSO : BaseSO
    {
        private Kupac kriterijum;
        public List<Kupac> Rezultat { get; set; }
        public PretraziKupacSO(Kupac kriterijum) { this.kriterijum = kriterijum; }
        protected override void ExecuteConcreteOperation()
        {
            Rezultat = broker.GetByCriteria(kriterijum).Cast<Kupac>().ToList();
        }
    }
}
