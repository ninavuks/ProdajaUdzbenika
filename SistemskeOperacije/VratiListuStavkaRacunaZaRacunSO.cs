using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace SistemskeOperacije
{
    public class VratiListuStavkaRacunaZaRacunSO : BaseSO
    {
        private int idRacun;
        public List<StavkaRacuna> Rezultat { get; set; }
        public VratiListuStavkaRacunaZaRacunSO(int idRacun) { this.idRacun = idRacun; }
        protected override void ExecuteConcreteOperation()
        {
            var kriterijum = new StavkaRacuna { IdRacun = idRacun };
            Rezultat = broker.GetByCriteria(kriterijum).Cast<StavkaRacuna>().ToList();
        }
    }
}
