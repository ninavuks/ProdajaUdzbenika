using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace SistemskeOperacije
{
    public class PretraziProdavacSO: BaseSO
    {
        private Prodavac kriterijum;
        public List<Prodavac> Rezultat { get; set; }
        public PretraziProdavacSO(Prodavac kriterijum) { this.kriterijum = kriterijum; }
        protected override void ExecuteConcreteOperation()
        {
            Rezultat = broker.GetByCriteria(kriterijum).Cast<Prodavac>().ToList();
        }
    
    }
}
