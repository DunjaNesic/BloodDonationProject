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

        public Server()
        {
            _socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public void Start()
        {
            try
            {
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
                    Thread thread = new Thread(new ThreadStart(ch.HandleRequest));
                    thread.IsBackground = true;
                    thread.Start();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(">>>>" + ex.Message);
            }
        }

        public void Stop()
        {
            _socket.Close();

            foreach (ClientHandler client in ClientHandler.clients)
            {
                client.Stop();
            }
            ClientHandler.clients.Clear();



        }
    }
}
