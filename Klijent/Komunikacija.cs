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
    }
}
