using System.Linq;
using Zajednicki.Domen;

namespace SistemskeOperacije
{
    public class PrijaviProdavacSO : BaseSO
    {
        private string korisnickoIme;
        private string sifra;
        public Prodavac Rezultat { get; set; }

        public PrijaviProdavacSO(string korisnickoIme, string sifra)
        {
            this.korisnickoIme = korisnickoIme;
            this.sifra = sifra;
        }

        protected override void ExecuteConcreteOperation()
        {
            var svi = broker.GetAll(new Prodavac()).Cast<Prodavac>().ToList();
            var prodavac = svi.FirstOrDefault(p => p.KorisnickoIme == korisnickoIme);

            if (prodavac == null)
                throw new Exception("Pogrešno korisničko ime");

            if (prodavac.Sifra != sifra)
                throw new Exception("Pogrešna lozinka");

            Rezultat = prodavac;
        }
    }
}