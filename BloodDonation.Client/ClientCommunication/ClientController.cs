using BloodDonation.Client.Exceptions;
using BloodDonation.Common.Communication;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.Client.ClientCommunication
{
    public class ClientController
    {
        private Sender _sender;
        private Receiver _receiver;
        private Socket _socket;
        public ClientController(Socket socket)
        {
            _socket = socket;
            _sender = new Sender(_socket);
            _receiver = new Receiver(_socket);
        }

        public void Send(Request req)
        {
            try
            {
                _sender.Send(req);
            }
            catch (IOException ex)
            {
                Debug.WriteLine("Send1>>>>" + ex.Message);
                throw new ServerCommunicationException("Konekcija sa serverom je prekinuta");
            }
            catch (SocketException ex)
            { 
                Debug.WriteLine("Send2>>>>>>>>" + ex.Message);
                throw new ServerCommunicationException("Vas soket je ugasen");
            }
        }
        public Response Receive()
        {
            Response resp = (Response)_receiver.Receive();
            if (resp.IsSuccessful) return resp;
            else
            {
                Debug.WriteLine("Receive>>>>>>>>>>>");
                throw new SystemOperationException(resp.ErrorMessage);
            }
        }

        public void Close() {
            _sender.Close();
            _receiver.Close();
        }
    }
}
