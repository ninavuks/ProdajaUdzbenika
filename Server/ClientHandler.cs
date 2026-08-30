using System.Diagnostics;
using System.Net.Sockets;
using Zajednicki.Domen;
using Zajednicki.Komunikacija;

namespace Server
{
    internal class ClientHandler
    {
        private Socket klijent;
        private readonly List<ClientHandler> klijenti;
        private JsonNetworkSerializer serializer;

        public ClientHandler(Socket klijent, List<ClientHandler> klijenti)
        {
            this.klijent = klijent;
            this.klijenti = klijenti;
            serializer = new JsonNetworkSerializer(klijent);
        }

        public void Handle()
        {
            try
            {
                while (true)
                {
                    Zahtev zahtev = serializer.Receive<Zahtev>();
                    Odgovor odgovor = ProcesuirajZahtev(zahtev);
                    serializer.Send(odgovor);
                }
            }
            catch (SocketException ex) { Debug.WriteLine(">>>SOCKET>>> " + ex.Message); }
            catch (IOException ex) { Debug.WriteLine(">>>IO>>> " + ex.Message); }
            finally
            {
                klijenti.Remove(this);
                serializer.Close();
            }
        }

        private Odgovor ProcesuirajZahtev(Zahtev zahtev)
        {
            Odgovor odgovor = new Odgovor { Uspesno = true };
            try
            {
                switch (zahtev.Operacija)
                {
                    case Operacija.VratiListuSviUdzbenik:
                        odgovor.Objekat = Kontroler.Instance.VratiListuSviUdzbenik();
                        break;
                    case Operacija.KreirajUdzbenik:
                        odgovor.Objekat = Kontroler.Instance.KreirajUdzbenik(
                            serializer.ReadType<Udzbenik>(zahtev.Objekat));
                        break;
                    case Operacija.PretraziUdzbenik:
                        odgovor.Objekat = Kontroler.Instance.PretraziUdzbenik(
                            serializer.ReadType<Udzbenik>(zahtev.Objekat));
                        break;
                    case Operacija.PromeniUdzbenik:
                        Kontroler.Instance.PromeniUdzbenik(serializer.ReadType<Udzbenik>(zahtev.Objekat));
                        break;
                    case Operacija.ObrisiUdzbenik:
                        Kontroler.Instance.ObrisiUdzbenik(serializer.ReadType<Udzbenik>(zahtev.Objekat));
                        break;
                }
            }
            catch (Exception ex)
            {
                odgovor.Greska = ex.Message;
                odgovor.Uspesno = false;
            }
            return odgovor;
        }

        internal void Close() => klijent.Close();
    }
}