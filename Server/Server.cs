using System.Net;
using System.Net.Sockets;

namespace Server
{
    internal class Server
    {
        private Socket socket;
        private List<ClientHandler> klijenti = new List<ClientHandler>();

        public Server() { socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp); }

        public void Start()
        {
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
            socket.Bind(endPoint);
            socket.Listen(5);
            new Thread(AcceptClient) { IsBackground = true }.Start();
        }

        public void AcceptClient()
        {
            try
            {
                while (true)
                {
                    Socket klijentskiSoket = socket.Accept();
                    ClientHandler handler = new ClientHandler(klijentskiSoket, klijenti);
                    klijenti.Add(handler);
                    new Thread(handler.Handle) { IsBackground = true }.Start();
                }
            }
            catch (Exception) { /* server je zaustavljen */ }
        }

        internal void Stop()
        {
            foreach (var k in klijenti) k.Close();
            klijenti.Clear();
            socket?.Close();
        }
    }
}