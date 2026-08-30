using SistemskeOperacije;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;

namespace Server
{
    internal class Kontroler
    {
        private static Kontroler instance;
        public static Kontroler Instance{
         get { if(instance == null) instance = new Kontroler(); return instance; }
        }

        private Kontroler() { }

        internal List<Udzbenik> VratiListuSviUdzbenik()
        {
            VratiListuSviUdzbenikSO so = new VratiListuSviUdzbenikSO();
            so.ExecuteTemplate();
            return so.Rezultat;
        }

        internal Udzbenik KreirajUdzbenik(Udzbenik udzbenik)
        {
            KreirajUdzbenikSO so = new KreirajUdzbenikSO(udzbenik);
            so.ExecuteTemplate();
            return so.Rezultat;
        }

        internal List<Udzbenik> PretraziUdzbenik(Udzbenik kriterijum)
        {
            PretraziUdzbenikSO so = new PretraziUdzbenikSO(kriterijum);
            so.ExecuteTemplate();
            return so.Rezultat;
        }

        internal void PromeniUdzbenik(Udzbenik udzbenik)
        {
            PromeniUdzbenikSO so = new PromeniUdzbenikSO(udzbenik);
            so.ExecuteTemplate();
        }
        internal void ObrisiUdzbenik(Udzbenik udzbenik)
        {
            ObrisiUdzbenikSO so = new ObrisiUdzbenikSO(udzbenik);
            so.ExecuteTemplate();
        }
    }
}
