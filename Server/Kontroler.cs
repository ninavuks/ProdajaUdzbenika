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

        internal List<OsnovnaSkola> VratiListuSviOsnovnaSkola()
        { 
            var so = new VratiListuSviOsnovnaSkolaSO(); 
            so.ExecuteTemplate(); 
            return so.Rezultat; 
        }
        internal OsnovnaSkola KreirajOsnovnaSkola(OsnovnaSkola s)
        { 
            var so = new KreirajOsnovnaSkolaSO(s);
            so.ExecuteTemplate();
            return so.Rezultat; 
        }
        internal List<OsnovnaSkola> PretraziOsnovnaSkola(OsnovnaSkola k)
        { 
            var so = new PretraziOsnovnaSkolaSO(k); 
            so.ExecuteTemplate(); 
            return so.Rezultat; 
        }
        internal void PromeniOsnovnaSkola(OsnovnaSkola s)
        { 
            var so = new PromeniOsnovnaSkolaSO(s);
            so.ExecuteTemplate(); 
        }
        internal void ObrisiOsnovnaSkola(OsnovnaSkola s)
        { 
            var so = new ObrisiOsnovnaSkolaSO(s); 
            so.ExecuteTemplate(); 
        }

        internal List<Obuka> VratiListuSviObuka()
        { 
            var so = new VratiListuSviObukaSO(); 
            so.ExecuteTemplate(); 
            return so.Rezultat; 
        }
        internal Obuka KreirajObuka(Obuka o)
        { 
            var so = new KreirajObukaSO(o); 
            so.ExecuteTemplate(); 
            return so.Rezultat; 
        }
        internal List<Obuka> PretraziObuka(Obuka k)
        { 
            var so = new PretraziObukaSO(k); 
            so.ExecuteTemplate(); 
            return so.Rezultat; 
        }
        internal void PromeniObuka(Obuka o)
        { 
            var so = new PromeniObukaSO(o); 
            so.ExecuteTemplate(); 
        }
        internal void ObrisiObuka(Obuka o)
        { var so = new ObrisiObukaSO(o); so.ExecuteTemplate(); }

        internal List<Prodavac> VratiListuSviProdavac()
        { 
            var so = new VratiListuSviProdavacSO(); 
            so.ExecuteTemplate(); 
            return so.Rezultat; 
        }
        internal Prodavac KreirajProdavac(Prodavac p)
        { 
            var so = new KreirajProdavacSO(p); 
            so.ExecuteTemplate(); 
            return so.Rezultat; 
        }
        internal List<Prodavac> PretraziProdavac(Prodavac k)
        { 
            var so = new PretraziProdavacSO(k); 
            so.ExecuteTemplate(); 
            return so.Rezultat; 
        }
        internal void PromeniProdavac(Prodavac p)
        { 
            var so = new PromeniProdavacSO(p);
            so.ExecuteTemplate();
        }
        internal void ObrisiProdavac(Prodavac p)
        { 
            var so = new ObrisiProdavacSO(p); 
            so.ExecuteTemplate(); 
        }
    }
}
