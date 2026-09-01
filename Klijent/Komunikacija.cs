using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Zajednicki.Domen;
using Zajednicki.Komunikacija;

namespace Klijent
{
    internal class Komunikacija
    {
        private static Komunikacija instance;
        public static Komunikacija Instance
        {
            get { if (instance == null) instance = new Komunikacija(); return instance; }
        }
        private Komunikacija() { }

        private Socket socket;
        private JsonNetworkSerializer serializer;

        internal void Connect()
        {
            if (socket == null || !socket.Connected)
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect("127.0.0.1", 9999);
                serializer = new JsonNetworkSerializer(socket);
            }
        }

        internal List<Udzbenik> VratiListuSviUdzbenik()
        {
            Zahtev zahtev = new Zahtev { Operacija = Operacija.VratiListuSviUdzbenik };
            serializer.Send(zahtev);
            Odgovor odgovor = serializer.Receive<Odgovor>();
            if (!odgovor.Uspesno) throw new Exception(odgovor.Greska);
            return serializer.ReadType<List<Udzbenik>>(odgovor.Objekat);
        }

        internal Udzbenik KreirajUdzbenik(Udzbenik udzbenik)
        {
            Zahtev zahtev = new Zahtev { Operacija = Operacija.KreirajUdzbenik, Objekat = udzbenik };
            serializer.Send(zahtev);
            Odgovor odgovor = serializer.Receive<Odgovor>();
            if (!odgovor.Uspesno) throw new Exception(odgovor.Greska);
            return serializer.ReadType<Udzbenik>(odgovor.Objekat);
        }

        internal List<Udzbenik> PretraziUdzbenik(Udzbenik kriterijum)
        {
            Zahtev zahtev = new Zahtev { Operacija = Operacija.PretraziUdzbenik, Objekat = kriterijum };
            serializer.Send(zahtev);
            Odgovor odgovor = serializer.Receive<Odgovor>();
            if (!odgovor.Uspesno) throw new Exception(odgovor.Greska);
            return serializer.ReadType<List<Udzbenik>>(odgovor.Objekat);
        }

        internal void PromeniUdzbenik(Udzbenik udzbenik)
        {
            Zahtev zahtev = new Zahtev { Operacija = Operacija.PromeniUdzbenik, Objekat = udzbenik };
            serializer.Send(zahtev);
            Odgovor odgovor = serializer.Receive<Odgovor>();
            if (!odgovor.Uspesno) throw new Exception(odgovor.Greska);
        }

        internal void ObrisiUdzbenik(Udzbenik udzbenik)
        {
            Zahtev zahtev = new Zahtev { Operacija = Operacija.ObrisiUdzbenik, Objekat = udzbenik };
            serializer.Send(zahtev);
            Odgovor odgovor = serializer.Receive<Odgovor>();
            if (!odgovor.Uspesno) throw new Exception(odgovor.Greska);
        }

        internal List<OsnovnaSkola> VratiListuSviOsnovnaSkola()
        {
            serializer.Send(new Zahtev { Operacija = Operacija.VratiListuSviOsnovnaSkola });
            var o = serializer.Receive<Odgovor>();
            if (!o.Uspesno) throw new Exception(o.Greska);
            return serializer.ReadType<List<OsnovnaSkola>>(o.Objekat);
        }
        internal OsnovnaSkola KreirajOsnovnaSkola(OsnovnaSkola s)
        {
            serializer.Send(new Zahtev { Operacija = Operacija.KreirajOsnovnaSkola, Objekat = s });
            var o = serializer.Receive<Odgovor>();
            if (!o.Uspesno) throw new Exception(o.Greska);
            return serializer.ReadType<OsnovnaSkola>(o.Objekat);
        }
        internal List<OsnovnaSkola> PretraziOsnovnaSkola(OsnovnaSkola k)
        {
            serializer.Send(new Zahtev { Operacija = Operacija.PretraziOsnovnaSkola, Objekat = k });
            var o = serializer.Receive<Odgovor>();
            if (!o.Uspesno) throw new Exception(o.Greska);
            return serializer.ReadType<List<OsnovnaSkola>>(o.Objekat);
        }
        internal void PromeniOsnovnaSkola(OsnovnaSkola s)
        {
            serializer.Send(new Zahtev { Operacija = Operacija.PromeniOsnovnaSkola, Objekat = s });
            var o = serializer.Receive<Odgovor>();
            if (!o.Uspesno) throw new Exception(o.Greska);
        }
        internal void ObrisiOsnovnaSkola(OsnovnaSkola s)
        {
            serializer.Send(new Zahtev { Operacija = Operacija.ObrisiOsnovnaSkola, Objekat = s });
            var o = serializer.Receive<Odgovor>();
            if (!o.Uspesno) throw new Exception(o.Greska);
        }

        internal List<Obuka> VratiListuSviObuka()
        {
            serializer.Send(new Zahtev { Operacija = Operacija.VratiListuSviObuka });
            var o = serializer.Receive<Odgovor>();
            if (!o.Uspesno) throw new Exception(o.Greska);
            return serializer.ReadType<List<Obuka>>(o.Objekat);
        }
        internal Obuka KreirajObuka(Obuka x)
        {
            serializer.Send(new Zahtev { Operacija = Operacija.KreirajObuka, Objekat = x });
            var o = serializer.Receive<Odgovor>();
            if (!o.Uspesno) throw new Exception(o.Greska);
            return serializer.ReadType<Obuka>(o.Objekat);
        }
        internal List<Obuka> PretraziObuka(Obuka k)
        {
            serializer.Send(new Zahtev { Operacija = Operacija.PretraziObuka, Objekat = k });
            var o = serializer.Receive<Odgovor>();
            if (!o.Uspesno) throw new Exception(o.Greska);
            return serializer.ReadType<List<Obuka>>(o.Objekat);
        }
        internal void PromeniObuka(Obuka x)
        {
            serializer.Send(new Zahtev { Operacija = Operacija.PromeniObuka, Objekat = x });
            var o = serializer.Receive<Odgovor>();
            if (!o.Uspesno) throw new Exception(o.Greska);
        }
        internal void ObrisiObuka(Obuka x)
        {
            serializer.Send(new Zahtev { Operacija = Operacija.ObrisiObuka, Objekat = x });
            var o = serializer.Receive<Odgovor>();
            if (!o.Uspesno) throw new Exception(o.Greska);
        }

        internal List<Prodavac> VratiListuSviProdavac()
        {
            serializer.Send(new Zahtev { Operacija = Operacija.VratiListuSviProdavac });
            var o = serializer.Receive<Odgovor>();
            if (!o.Uspesno) throw new Exception(o.Greska);
            return serializer.ReadType<List<Prodavac>>(o.Objekat);
        }
        internal Prodavac KreirajProdavac(Prodavac p)
        {
            serializer.Send(new Zahtev { Operacija = Operacija.KreirajProdavac, Objekat = p });
            var o = serializer.Receive<Odgovor>();
            if (!o.Uspesno) throw new Exception(o.Greska);
            return serializer.ReadType<Prodavac>(o.Objekat);
        }
        internal List<Prodavac> PretraziProdavac(Prodavac k)
        {
            serializer.Send(new Zahtev { Operacija = Operacija.PretraziProdavac, Objekat = k });
            var o = serializer.Receive<Odgovor>();
            if (!o.Uspesno) throw new Exception(o.Greska);
            return serializer.ReadType<List<Prodavac>>(o.Objekat);
        }
        internal void PromeniProdavac(Prodavac p)
        {
            serializer.Send(new Zahtev { Operacija = Operacija.PromeniProdavac, Objekat = p });
            var o = serializer.Receive<Odgovor>();
            if (!o.Uspesno) throw new Exception(o.Greska);
        }
        internal void ObrisiProdavac(Prodavac p)
        {
            serializer.Send(new Zahtev { Operacija = Operacija.ObrisiProdavac, Objekat = p });
            var o = serializer.Receive<Odgovor>();
            if (!o.Uspesno) throw new Exception(o.Greska);
        }

        internal List<Kupac> VratiListuSviKupac()
        {
            serializer.Send(new Zahtev { Operacija = Operacija.VratiListuSviKupac });
            var o = serializer.Receive<Odgovor>();
            if (!o.Uspesno) throw new Exception(o.Greska);
            return serializer.ReadType<List<Kupac>>(o.Objekat);
        }
        internal Kupac KreirajKupac(Kupac k)
        {
            serializer.Send(new Zahtev { Operacija = Operacija.KreirajKupac, Objekat = k });
            var o = serializer.Receive<Odgovor>();
            if (!o.Uspesno) throw new Exception(o.Greska);
            return serializer.ReadType<Kupac>(o.Objekat);
        }
        internal List<Kupac> PretraziKupac(Kupac kriterijum)
        {
            serializer.Send(new Zahtev { Operacija = Operacija.PretraziKupac, Objekat = kriterijum });
            var o = serializer.Receive<Odgovor>();
            if (!o.Uspesno) throw new Exception(o.Greska);
            return serializer.ReadType<List<Kupac>>(o.Objekat);
        }
        internal void PromeniKupac(Kupac k)
        {
            serializer.Send(new Zahtev { Operacija = Operacija.PromeniKupac, Objekat = k });
            var o = serializer.Receive<Odgovor>();
            if (!o.Uspesno) throw new Exception(o.Greska);
        }
        internal void ObrisiKupac(Kupac k)
        {
            serializer.Send(new Zahtev { Operacija = Operacija.ObrisiKupac, Objekat = k });
            var o = serializer.Receive<Odgovor>();
            if (!o.Uspesno) throw new Exception(o.Greska);
        }

        internal Prodavac PrijaviProdavac(string korisnickoIme, string sifra)
        {
            var kriterijum = new Prodavac { KorisnickoIme = korisnickoIme, Sifra = sifra };
            serializer.Send(new Zahtev { Operacija = Operacija.PrijaviProdavac, Objekat = kriterijum });
            var o = serializer.Receive<Odgovor>();
            if (!o.Uspesno) 
                throw new Exception(o.Greska);
                return serializer.ReadType<Prodavac>(o.Objekat);
        }

        internal List<Racun> VratiListuSviRacun()
        {
            serializer.Send(new Zahtev { Operacija = Operacija.VratiListuSviRacun });
            var o = serializer.Receive<Odgovor>();
            if (!o.Uspesno) throw new Exception(o.Greska);
            return serializer.ReadType<List<Racun>>(o.Objekat);
        }
        internal Racun KreirajRacunSaStavkama(RacunSaStavkama paket)
        {
            serializer.Send(new Zahtev { Operacija = Operacija.KreirajRacunSaStavkama, Objekat = paket });
            var o = serializer.Receive<Odgovor>();
            if (!o.Uspesno) throw new Exception(o.Greska);
            return serializer.ReadType<Racun>(o.Objekat);
        }
        internal List<Racun> PretraziRacun(Racun kriterijum)
        {
            serializer.Send(new Zahtev { Operacija = Operacija.PretraziRacun, Objekat = kriterijum });
            var o = serializer.Receive<Odgovor>();
            if (!o.Uspesno) throw new Exception(o.Greska);
            return serializer.ReadType<List<Racun>>(o.Objekat);
        }
        internal void PromeniRacun(Racun racun)
        {
            serializer.Send(new Zahtev { Operacija = Operacija.PromeniRacun, Objekat = racun });
            var o = serializer.Receive<Odgovor>();
            if (!o.Uspesno) throw new Exception(o.Greska);
        }
        internal List<StavkaRacuna> VratiListuStavkaRacunaZaRacun(int idRacun)
        {
            serializer.Send(new Zahtev { Operacija = Operacija.VratiListuStavkaRacunaZaRacun, Objekat = new Racun { Id = idRacun } });
            var o = serializer.Receive<Odgovor>();
            if (!o.Uspesno) throw new Exception(o.Greska);
            return serializer.ReadType<List<StavkaRacuna>>(o.Objekat);
        }
    }
}
