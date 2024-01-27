using BloodDonation.Common.Communication;
using BloodDonation.Common.Domain;
using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
        public EventHandler LoggedOutClient;
        public EventHandler LoggedInClient;
        public TransfusionCenterCoordinator _coordinator;
        //public static List<ClientHandler> clients = new List<ClientHandler>();
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
            catch (IOException ex)
            {
                Debug.WriteLine(">>>>>" + ex.Message);
            }
            finally {
                Stop();
            }
        }

        public Response ProcessRequest(Request req)
        {
            Response resp = new Response();
            switch (req.Operation)
            {
                case Operation.Login:                 
                    TransfusionCenterCoordinator loggedCoord = Controller.Instance.Login((TransfusionCenterCoordinator)req.Argument);
                    if (loggedCoord != null)
                    {
                        this._coordinator = loggedCoord;
                        resp.Result = loggedCoord;
                        LoggedInClient?.Invoke(this, EventArgs.Empty);
                    }
                    else {
                        resp.IsSuccessful = false;
                    }
                    break;
                case Operation.CreateVolunteer:
                    Volunteer newVolunteer = Controller.Instance.CreateNewVolunteer((Volunteer)req.Argument);
                    resp.Result = newVolunteer;
                    break;
                case Operation.FindVolunteers:
                    List<Volunteer> filteredVolunteers = Controller.Instance.GetFilteredVolunteers(new Volunteer()
                    {
                        FilterQuery = (string)req.Argument
                    });
                    resp.Result = filteredVolunteers;
                    break;
                case Operation.LoadVolunteer:
                    break;
                case Operation.DeleteVolunteer:
                    Volunteer volToDelete = (Volunteer)req.Argument;
                    bool deleted = Controller.Instance.DeleteVolunteer(volToDelete);
                    resp.Result = deleted;
                    break;
                case Operation.GetAllVolunteers:
                    List<Volunteer> volunteers = Controller.Instance.GetAllVolunteers(new Volunteer());
                    resp.Result = volunteers;
                    break;
                case Operation.CreateDonor:
                    break;
                case Operation.FindDonor:
                    break;
                case Operation.DeleteDonor:
                    break;
                case Operation.GetAllDonors:
                    break;
                case Operation.CreateCallToAction:
                    break;
                case Operation.StoreAction:
                    break;
                case Operation.FindCallToAction:
                    break;
                case Operation.LoadAction:
                    break;
                case Operation.GetAllActions:
                    break;
                case Operation.GetAllCallsToAction:
                    break;
                case Operation.GetAllPlaces:
                    List<Place> places = Controller.Instance.GetAllPlaces(new Place());
                    resp.Result = places;
                    break;
                default:
                    break;
            }
            return resp;
        }

        private object lockobj = new object();
        public void Stop()
        {
            lock (lockobj)
            {
                if (_socket != null)
                {
                    _socket.Shutdown(SocketShutdown.Both);
                    _socket.Close();
                    _socket = null;
                    LoggedOutClient?.Invoke(this, EventArgs.Empty);
                }
            }
        }
    }
}
