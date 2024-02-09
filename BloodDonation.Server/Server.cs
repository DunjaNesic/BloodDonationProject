using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Configuration;

namespace BloodDonation.Server
{
    public class Server
    {
        private Socket _socket;
        public List<ClientHandler> clients = new List<ClientHandler>();
        private static Server _instance;
        public event EventHandler LoggedInClient;
        public event EventHandler LoggedOutClient;
        public static Server Instance
        {
            get
            {
                if (_instance == null)
                        {
                            _instance = new Server();
                        }                                  
                return _instance;
            }
        }       
        public void Start()
        {
            try
            {
                _socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(ConfigurationManager.AppSettings["ip"]), int.Parse(ConfigurationManager.AppSettings["port"]));
                _socket.Bind(endPoint);
                _socket.Listen(42);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(">>>>>" + ex.Message);
            }
        }

        public void Listen()
        {
            try
            {
                while (true)
                {
                    Socket clientSocket = _socket.Accept();
                    ClientHandler ch = new ClientHandler(clientSocket);
                    
                    ch.LoggedOutClient += Handler_LoggedOutClient;
                    ch.LoggedInClient += Handler_LoggedInClient;
                    Thread thread = new Thread(new ThreadStart(ch.HandleRequest));
                    thread.IsBackground = true;
                    thread.Start();
                }
            }
            catch (SocketException ex)
            {
                Debug.WriteLine(">>>>>" + ex.Message);
            }
        }
        public void Handler_LoggedInClient(object sender, EventArgs e)
        {
            clients.Add((ClientHandler)sender);
            LoggedInClient?.Invoke(sender, e);
        }

        public void Handler_LoggedOutClient(object sender, EventArgs args) {
            clients.Remove((ClientHandler)sender);
            LoggedOutClient?.Invoke(sender, args);
        }

        public void Stop()
        {
            _socket.Close();

            foreach (ClientHandler client in clients.ToList())
            {
                client.Stop();
            }
        }


    }
}
