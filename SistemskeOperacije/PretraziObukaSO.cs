using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace SistemskeOperacije
{
    public class PretraziObukaSO : BaseSO  
    {
        private Obuka kriterijum;
        public List<Obuka> Rezultat { get; set; }

        public PretraziObukaSO(Obuka kriterijum) { this.kriterijum = kriterijum; }
        
        protected override void ExecuteConcreteOperation()
        {
            Rezultat = broker.GetByCriteria(kriterijum).Cast<Obuka>().ToList();
        }
    }
}
