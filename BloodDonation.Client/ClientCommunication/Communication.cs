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
using BloodDonation.Client.Exceptions;
using System.Windows.Forms;

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
        public void Connect()
        {
            try
            {
                _socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                _socket.Connect("127.0.0.1", 9999);
                _clientController = new ClientController(_socket);            
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Connect>>>>" + ex.Message);
                throw new ServerCommunicationException("Konekcija sa serverom nije uspostavljena");             
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
            MessageBox.Show(resp.Message);
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

        internal void DeleteVolunteer(Volunteer selectedVol)
        {
            _clientController.Send(new Request() { 
            Operation = Operation.DeleteVolunteer,
            Argument = selectedVol
            });
            Response resp = _clientController.Receive();
            MessageBox.Show(resp.Message);
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
            MessageBox.Show(resp.Message);
            return resp.ParseResponse<Volunteer>();
        }
        internal Donor CreateDonor(Donor donor)
        {
            _clientController.Send(new Request()
            {
                Operation = Operation.CreateDonor,
                Argument = donor
            });
            Response resp = _clientController.Receive();
            MessageBox.Show(resp.Message);
            return resp.ParseResponse<Donor>();
        }

        internal void DeleteDonor(Donor selectedDonor)
        {
            _clientController.Send(new Request()
            {
                Operation = Operation.DeleteDonor,
                Argument = selectedDonor
            });
            Response resp = _clientController.Receive();
            MessageBox.Show(resp.Message); 
        }

        internal List<Donor> GetAllDonors()
        {
            _clientController.Send(new Request()
            {
                Operation = Operation.GetAllDonors
            });
            Response resp = _clientController.Receive();
            return resp.ParseResponse<List<Donor>>();
        }

        internal List<Questionnaire> GetAllQuestionnaires(Donor donor)
        {
            _clientController.Send(new Request()
            {
                Operation = Operation.GetAllQuestionnaires,
                Argument = donor
            });
            Response resp = _clientController.Receive();
            return resp.ParseResponse<List<Questionnaire>>();
        }

        internal Donor FilterDonor(string filterCondition)
        {
            _clientController.Send(new Request()
            {
                Operation = Operation.FindDonor,
                Argument = filterCondition
            });
            Response resp = _clientController.Receive();
            MessageBox.Show(resp.Message);
            return resp.ParseResponse<Donor>();
        }

        internal void UpdateDonor(Donor donorToUpdate)
        {
            _clientController.Send(new Request() { 
            Operation = Operation.UpdateDonor,
            Argument = donorToUpdate
            });
            Response resp = _clientController.Receive();
            MessageBox.Show(resp.Message);
         
        }

        internal List<BloodTransfAction> GetAllActions()
        {
            _clientController.Send(new Request() { 
            Operation = Operation.GetAllActions
            });
            Response resp = _clientController.Receive();
            return resp.ParseResponse<List<BloodTransfAction>>();
        }

        internal Volunteer GetVolunteer(int volunteerID)
        {
            _clientController.Send(new Request() { 
            Operation = Operation.LoadVolunteer,
            Argument = volunteerID
            });
            Response resp = _clientController.Receive();
            MessageBox.Show(resp.Message);
            return resp.ParseResponse<Volunteer>();
        }

        internal void CallToAction(BloodTransfAction bloodTransfAction)
        {
            _clientController.Send(new Request() { 
            Operation = Operation.CreateCallToAction,
            Argument = bloodTransfAction
            });
            Response resp = _clientController.Receive();
            MessageBox.Show(resp.Message);
        }

        internal void UpdateCallToAction(BloodTransfAction action)
        {
            _clientController.Send(new Request()
            {
                Operation = Operation.UpdateCallToAction,
                Argument = action
            });
            Response resp = _clientController.Receive();
            MessageBox.Show(resp.Message);
        }

        internal BloodTransfAction GetAction(int actionID)
        {
            _clientController.Send(new Request()
            {
                Operation = Operation.LoadAction,
                Argument = actionID
            });
            Response resp = _clientController.Receive();
            MessageBox.Show(resp.Message);
            return resp.ParseResponse<BloodTransfAction>();
        }

        internal List<CallToVolunteer> FindVolunteerCalls(BloodTransfAction loadedAction)
        {
            _clientController.Send(new Request()
            {
                Operation = Operation.FindVolunteerCalls,
                Argument = loadedAction
            });
            Response resp = _clientController.Receive();
            return resp.ParseResponse<List<CallToVolunteer>>();
        }

        internal List<CallToDonor> FindDonorCalls(BloodTransfAction loadedAction)
        {
            _clientController.Send(new Request()
            {
                Operation = Operation.FindDonorCalls,
                Argument = loadedAction
            });
            Response resp = _clientController.Receive();
            return resp.ParseResponse<List<CallToDonor>>();
        }

        internal List<Donor> FilterDonors(string filterDonorsByPlace)
        {
            _clientController.Send(new Request() { 
                Operation = Operation.FindDonors,
                Argument = filterDonorsByPlace
            });
            Response resp = _clientController.Receive();
            return resp.ParseResponse<List<Donor>>();
        }
    }
}
