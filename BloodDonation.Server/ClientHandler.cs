using BloodDonation.Common.Communication;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.Server
{
    public class ClientHandler
    {

        private Socket _socket;
        private Sender _sender;
        private Receiver _receiver;
        public static List<ClientHandler> clients = new List<ClientHandler>();
        bool kraj = false;
       
        public ClientHandler(Socket clientSocket)
        {
            _socket = clientSocket;
            _sender = new Sender(_socket);
            _receiver = new Receiver(_socket);
        }

        internal void HandleRequest()
        {
            try
            {
                while (!kraj)
                {
                    Request req = (Request)_receiver.Receive();
                    Response resp = ProcessRequest(req);
                    _sender.Send(resp);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(">>>>>" + ex.Message);
            }
        }

        public Response ProcessRequest(Request req)
        {
            Response resp = new Response();
            switch (req.Operation)
            {
                default:
                    break;
            }
            return resp;
        }

        public void Stop()
        {
            _socket.Shutdown(SocketShutdown.Both);
            _socket.Close();
        }
    }
}
