using BloodDonation.Client.Exceptions;
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
            try
            {
                switch (req.Operation)
                {
                    case Operation.Login:
                        TransfusionCenterCoordinator loggedCoord = Controller.Instance.Login((TransfusionCenterCoordinator)req.Argument);
                        if (loggedCoord != null)
                        {
                            _coordinator = loggedCoord;
                            resp.Result = loggedCoord;
                            resp.Message = "Uspešno prijavljivanje";
                            LoggedInClient?.Invoke(this, EventArgs.Empty);
                        }
                        else
                        {
                            resp.IsSuccessful = false;
                            resp.ErrorMessage = "Neuspešno prijavljivanje na sistem";
                        }
                        break;
                    case Operation.CreateVolunteer:
                        Volunteer newVolunteer = Controller.Instance.CreateNewVolunteer((Volunteer)req.Argument);
                        if (newVolunteer != null)
                        {
                            resp.Result = newVolunteer;
                            resp.Message = "Sistem je kreirao volontera";
                        }
                        else
                        {
                            resp.IsSuccessful = false;
                            resp.ErrorMessage = "Sistem ne može da kreira volontera";
                        }
                        break;
                    case Operation.FindVolunteers:
                        List<Volunteer> filteredVolunteers = Controller.Instance.GetFilteredVolunteers(new Volunteer()
                        {
                            FilterQuery = (string)req.Argument
                        });
                        resp.Result = filteredVolunteers;
                        break;
                    case Operation.UpdateDonor:
                        Controller.Instance.UpdateDonor((Donor)req.Argument);
                        resp.Message = "Sistem je zapamtio davaoca";
                        break;
                    case Operation.DeleteVolunteer:
                        Volunteer volToDelete = (Volunteer)req.Argument;
                        Controller.Instance.DeleteVolunteer(volToDelete);
                        resp.Message = "Sistem je obrisao volontera";
                        break;
                    case Operation.GetAllVolunteers:
                        List<Volunteer> volunteers = Controller.Instance.GetAllVolunteers(new Volunteer());
                        resp.Result = volunteers;
                        break;
                    case Operation.CreateDonor:
                        Donor newDonor = Controller.Instance.CreateNewDonor((Donor)req.Argument);
                        if (newDonor != null)
                        {
                            resp.Result = newDonor;
                            resp.Message = ("Sistem je kreirao davaoca");
                        }
                        else
                        {
                            resp.IsSuccessful = false;
                            resp.ErrorMessage = "Sistem ne može da kreira davaoca";
                        }
                        break;
                    case Operation.FindDonor:
                        Donor foundDonor = Controller.Instance.FindDonor(new Donor()
                        {
                            FilterQuery = (string)req.Argument
                        });
                        if (foundDonor != null)
                        {
                            resp.Result = foundDonor;
                            resp.Message = "Sistem je našao davaoca po zadatoj vrednosti";
                        }
                        else
                        {
                            resp.IsSuccessful = false;
                            resp.ErrorMessage = "Sistem ne može da pronađe davaoca po zadatoj vrednosti";
                        }
                        break;
                    case Operation.DeleteDonor:
                        Donor donorToDelete = (Donor)req.Argument;
                        Controller.Instance.DeleteDonor(donorToDelete);
                        resp.Message = "Sistem je obrisao davaoca";
                        break;
                    case Operation.GetAllDonors:
                        List<Donor> donors = Controller.Instance.GetAllDonors(new Donor());
                        resp.Result = donors;
                        break;
                    case Operation.CreateCallToAction:
                        Controller.Instance.CreateNewCallToAction((BloodTransfAction)req.Argument);
                        resp.Message = "Sistem je kreirao poziv na akciju";
                        break;
                    case Operation.UpdateCallToAction:
                        Controller.Instance.UpdateCallToAction((BloodTransfAction)req.Argument);
                        resp.Message = "Sistem je ažurirao pozive na akciju";
                        break;
                    case Operation.LoadAction:
                        BloodTransfAction loadedAction = Controller.Instance.LoadAction(new BloodTransfAction()
                        {
                            FilterQuery = $"a.actionID = {(int)req.Argument}"
                        });
                        if (loadedAction != null)
                        {
                            resp.Message = "Sistem je učitao akciju";
                            resp.Result = loadedAction;
                        }
                        else
                        {
                            resp.IsSuccessful = false;
                            resp.ErrorMessage = "Sistem ne može da učita akciju";
                        }
                        break;
                    case Operation.GetAllCallsToAction:
                        break;
                    case Operation.GetAllActions:
                        List<BloodTransfAction> actions = Controller.Instance.GetAllActions(new BloodTransfAction());
                        resp.Result = actions;
                        break;
                    case Operation.GetAllPlaces:
                        List<Place> places = Controller.Instance.GetAllPlaces(new Place());
                        resp.Result = places;
                        break;
                    case Operation.GetAllQuestionnaires:
                        Donor d = (Donor)req.Argument;
                        List<Questionnaire> questionnaires = Controller.Instance.GetAllQuestionnaires(new Questionnaire()
                        {
                            FilterQuery = $"JMBG = {d.JMBG}"
                        });
                        resp.Result = questionnaires;
                        break;
                    case Operation.LoadVolunteer:
                        Volunteer loadedVol = Controller.Instance.LoadVolunteer(new Volunteer()
                        {
                            FilterQuery = $"v.VolunteerID = {(int)req.Argument}"
                        });
                        if (loadedVol != null)
                        {
                            resp.Message = "Sistem je učitao volontera";
                            resp.Result = loadedVol;
                        }
                        else
                        {
                            resp.IsSuccessful = false;
                            resp.ErrorMessage = "Sistem ne može da učita volontera";
                        }
                        break;
                    case Operation.FindVolunteerCalls:
                        List<CallToVolunteer> volunteerCalls = Controller.Instance.GetVolunteerCalls((BloodTransfAction)req.Argument);
                        resp.Result = volunteerCalls;
                        break;
                    case Operation.FindDonorCalls:
                        List<CallToDonor> donorCalls = Controller.Instance.GetDonorCalls((BloodTransfAction)req.Argument);
                        resp.Result = donorCalls;
                        break;
                    case Operation.FindDonors:
                        List<Donor> filteredDonors = Controller.Instance.GetFilteredDonors(new Donor()
                        {
                            FilterQuery = (string)req.Argument
                        });
                        resp.Result = filteredDonors;
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                resp.IsSuccessful = false;
                resp.ErrorMessage = ex.Message;
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
