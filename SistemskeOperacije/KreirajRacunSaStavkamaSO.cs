using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Zajednicki.Domen;

namespace SistemskeOperacije
{
    public class KreirajRacunSaStavkamaSO : BaseSO
    {
        private RacunSaStavkama paket;
        public Racun Rezultat { get; set; }

        public KreirajRacunSaStavkamaSO(RacunSaStavkama paket) { this.paket = paket; }

        protected override void ExecuteConcreteOperation()
        {
            var racun = paket.Racun;
            var stavke = paket.Stavke;

            if (stavke == null || stavke.Count == 0)
                throw new Exception("Račun mora imati bar jednu stavku.");

            racun.UkupanIznos = stavke.Sum(s => s.Cena * s.Kolicina);
            racun.Id = broker.Add(racun);

            int rb = 1;
            foreach (var stavka in stavke)
            {
                stavka.IdRacun = racun.Id;
                stavka.Rb = rb;
                stavka.Iznos = stavka.Cena * stavka.Kolicina;
                broker.Add(stavka);
                rb++;
            }

            Rezultat = racun;
        }
    }
}
