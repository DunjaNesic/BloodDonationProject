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
using System.IO;
using System.Runtime.Serialization;
using BloodDonation.Client.GUIController;
using System.Threading;
using BloodDonation.Client.Forms;

namespace BloodDonation.Client.ClientCommunication
{
    public class Communication
    {
        private Socket _socket;       
        private static Communication _instance;
        private ClientController _clientController;
        private static readonly object lockobj = new object();      
        public static Communication Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (lockobj)
                    {
                        if (_instance == null)
                        {
                            _instance = new Communication();
                        }
                    }
                }
                return _instance;
            }
        }
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

        internal TransfusionCenterCoordinator LoginCoord(string coordinatorCode, string password)
        {
            _clientController.Send(new Request()
            {
                Operation = Operation.Login,
                Argument = new TransfusionCenterCoordinator()
                {
                    CoordinatorCode = coordinatorCode,
                    Password = password
                }
            });
            Response resp = _clientController.Receive();
            if (resp.IsSuccessful == false) return null;
            return resp.ParseResponse<TransfusionCenterCoordinator>();
        }
        internal List<Volunteer> GetAllVolunteers()
        {
            _clientController.Send(new Request() { 
            Operation = Operation.GetAllVolunteers
            });
            Response resp = _clientController.Receive();
            return resp.ParseResponse<List<Volunteer>>();
        }

        internal List<Volunteer> FilterVolunteers(string filterCondition)
        {
            _clientController.Send(new Request() { 
            Operation = Operation.FindVolunteers,
            Argument = filterCondition
            });
            Response resp = _clientController.Receive();
            return resp.ParseResponse<List<Volunteer>>();
        }

        internal bool DeleteVolunteer(Volunteer selectedVol)
        {
            _clientController.Send(new Request() { 
            Operation = Operation.DeleteVolunteer,
            Argument = selectedVol
            });
            Response resp = _clientController.Receive();
            return resp.ParseResponse<bool>();
        }

        internal List<Place> GetAllPlaces()
        {
            _clientController.Send(new Request() { 
            Operation = Operation.GetAllPlaces
            });
            Response resp = _clientController.Receive();
            return resp.ParseResponse<List<Place>>();
        }

        internal Volunteer CreateVolunteer(Volunteer volunteer)
        {
            _clientController.Send(new Request() { 
            Operation = Operation.CreateVolunteer,
            Argument = volunteer
            });
            Response resp = _clientController.Receive();
            return resp.ParseResponse<Volunteer>();
        }




        //public Donor Dunja(Request req) {
        //    _clientController.Send(req);
        //    Response resp = _clientController.Receive();
        //    return resp.ParseResponse<Donor>();
        //}

    }
}
