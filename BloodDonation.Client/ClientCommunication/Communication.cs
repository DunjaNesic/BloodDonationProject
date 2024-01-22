using BloodDonation.Common.Communication;
using BloodDonation.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using BloodDonation.Common.Domain;

namespace BloodDonation.Client.ClientCommunication
{
    public class Communication
    {
        private Socket _socket;       
        private static Communication _instance;
        private ClientController _clientController;
        public static Communication Instance { get { if (_instance == null) _instance = new Communication(); return _instance; } }
        public bool Connect()
        {
            try
            {
                _socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                _socket.Connect("127.0.0.1", 9999);
                _clientController = new ClientController(_socket);
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(">>>" + ex.Message);
                return false;
            }
        }
        public void Close()
        {
            _socket.Close();
            _socket = null;
            _clientController.Close();
        }

        //metode ce izgledati ovako
        //public Donor Dunja(Request req) {
        //    _clientController.Send(req);
        //    Response resp = _clientController.Receive();
        //    return resp.ParseResponse<Donor>();
        //}

    }
}
