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
                    case Operacija.VratiListuSviOsnovnaSkola:
                        odgovor.Objekat = Kontroler.Instance.VratiListuSviOsnovnaSkola(); 
                        break;
                    case Operacija.KreirajOsnovnaSkola:
                        odgovor.Objekat = Kontroler.Instance.KreirajOsnovnaSkola(serializer.ReadType<OsnovnaSkola>(zahtev.Objekat)); 
                        break;
                    case Operacija.PretraziOsnovnaSkola:
                        odgovor.Objekat = Kontroler.Instance.PretraziOsnovnaSkola(serializer.ReadType<OsnovnaSkola>(zahtev.Objekat)); 
                        break;
                    case Operacija.PromeniOsnovnaSkola:
                        Kontroler.Instance.PromeniOsnovnaSkola(serializer.ReadType<OsnovnaSkola>(zahtev.Objekat)); 
                        break;
                    case Operacija.ObrisiOsnovnaSkola:
                        Kontroler.Instance.ObrisiOsnovnaSkola(serializer.ReadType<OsnovnaSkola>(zahtev.Objekat)); 
                        break;

                    case Operacija.VratiListuSviObuka:
                        odgovor.Objekat = Kontroler.Instance.VratiListuSviObuka(); 
                        break;
                    case Operacija.KreirajObuka:
                        odgovor.Objekat = Kontroler.Instance.KreirajObuka(serializer.ReadType<Obuka>(zahtev.Objekat)); 
                        break;
                    case Operacija.PretraziObuka:
                        odgovor.Objekat = Kontroler.Instance.PretraziObuka(serializer.ReadType<Obuka>(zahtev.Objekat)); break;
                    case Operacija.PromeniObuka:
                        Kontroler.Instance.PromeniObuka(serializer.ReadType<Obuka>(zahtev.Objekat)); 
                        break;
                    case Operacija.ObrisiObuka:
                        Kontroler.Instance.ObrisiObuka(serializer.ReadType<Obuka>(zahtev.Objekat)); 
                        break;

                    case Operacija.VratiListuSviProdavac:
                        odgovor.Objekat = Kontroler.Instance.VratiListuSviProdavac(); 
                        break;
                    case Operacija.KreirajProdavac:
                        odgovor.Objekat = Kontroler.Instance.KreirajProdavac(serializer.ReadType<Prodavac>(zahtev.Objekat)); 
                        break;
                    case Operacija.PretraziProdavac:
                        odgovor.Objekat = Kontroler.Instance.PretraziProdavac(serializer.ReadType<Prodavac>(zahtev.Objekat)); 
                        break;
                    case Operacija.PromeniProdavac:
                        Kontroler.Instance.PromeniProdavac(serializer.ReadType<Prodavac>(zahtev.Objekat)); 
                        break;
                    case Operacija.ObrisiProdavac:
                        Kontroler.Instance.ObrisiProdavac(serializer.ReadType<Prodavac>(zahtev.Objekat)); 
                        break;

                    case Operacija.VratiListuSviKupac:
                        odgovor.Objekat = Kontroler.Instance.VratiListuSviKupac(); 
                        break;
                    case Operacija.KreirajKupac:
                        odgovor.Objekat = Kontroler.Instance.KreirajKupac(serializer.ReadType<Kupac>(zahtev.Objekat)); 
                        break;
                    case Operacija.PretraziKupac:
                        odgovor.Objekat = Kontroler.Instance.PretraziKupac(serializer.ReadType<Kupac>(zahtev.Objekat)); 
                        break;
                    case Operacija.PromeniKupac:
                        Kontroler.Instance.PromeniKupac(serializer.ReadType<Kupac>(zahtev.Objekat)); 
                        break;
                    case Operacija.ObrisiKupac:
                        Kontroler.Instance.ObrisiKupac(serializer.ReadType<Kupac>(zahtev.Objekat)); 
                        break;
                    case Operacija.PrijaviProdavac:
                        Prodavac kriterijumPrijava = serializer.ReadType<Prodavac>(zahtev.Objekat);
                        odgovor.Objekat = Kontroler.Instance.PrijaviProdavac(kriterijumPrijava.KorisnickoIme, kriterijumPrijava.Sifra);
                        break;

                    case Operacija.VratiListuSviRacun:
                        odgovor.Objekat = Kontroler.Instance.VratiListuSviRacun(); 
                        break;
                    case Operacija.KreirajRacunSaStavkama:
                        odgovor.Objekat = Kontroler.Instance.KreirajRacunSaStavkama(serializer.ReadType<RacunSaStavkama>(zahtev.Objekat)); 
                        break;
                    case Operacija.PretraziRacun:
                        odgovor.Objekat = Kontroler.Instance.PretraziRacun(serializer.ReadType<Racun>(zahtev.Objekat)); 
                        break;
                    case Operacija.PromeniRacun:
                        Kontroler.Instance.PromeniRacun(serializer.ReadType<Racun>(zahtev.Objekat)); 
                        break;
                    case Operacija.VratiListuStavkaRacunaZaRacun:
                        Racun racunKriterijum = serializer.ReadType<Racun>(zahtev.Objekat);
                        odgovor.Objekat = Kontroler.Instance.VratiListuStavkaRacunaZaRacun(racunKriterijum.Id);
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