using BloodDonation.Common.Domain;
using BloodDonation.Repository.Implementation;
using BloodDonation.Repository.Interfaces;
using BloodDonation.SystemOperations;
using BloodDonation.SystemOperations.ActionSO;
using BloodDonation.SystemOperations.DonorSO;
using BloodDonation.SystemOperations.TransfusionCoordinator;
using BloodDonation.SystemOperations.VolunteerSO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace BusinessLogic
{
    public class Controller
    {
        private static Controller _instance;
        public static Controller Instance { get { if (_instance == null) _instance = new Controller(); return _instance; } }

        public void CreateNewCallToAction(BloodTransfAction act)
        {
            SystemOperationBase so = new CreateCallToActionSO();
            so.ExecuteTemplate(act);
        }

        public Donor CreateNewDonor(Donor donor)
        {
            SystemOperationBase so = new AddDonorSO();
            so.ExecuteTemplate(donor);
            return (Donor)so.Result;
        }

        public Volunteer CreateNewVolunteer(Volunteer volunteer)
        {
            SystemOperationBase so = new AddVolunteerSO();
            so.ExecuteTemplate(volunteer);
            return (Volunteer)so.Result;
        }

        public void DeleteAction(BloodTransfAction action)
        {
            SystemOperationBase so = new DeleteActionSO();
            so.ExecuteTemplate(action);
        }

        public void DeleteDonor(Donor donor)
        {
            SystemOperationBase so = new DeleteDonorSO();
            so.ExecuteTemplate(donor);          
        }

        public void DeleteVolunteer(Volunteer volunteer)
        {
            SystemOperationBase so = new DeleteVolunteerSO();
            so.ExecuteTemplate(volunteer);
           
        }

        public Donor FindDonor(Donor donor)
        {
            SystemOperationBase so = new FindDonorSO();
            so.ExecuteTemplate(donor);
            return (Donor)so.Result;
        }

        public List<BloodTransfAction> GetAllActions(BloodTransfAction bloodTransfAction)
        {
            SystemOperationBase so = new GetAllActionsSO();
            so.ExecuteTemplate(bloodTransfAction);
            return (List<BloodTransfAction>)so.Result;
        }

        public List<Donor> GetAllDonors(Donor donor)
        {
            SystemOperationBase so = new GetAllDonorsSO();
            so.ExecuteTemplate(donor);
            return (List<Donor>)so.Result;
        }

        public List<Place> GetAllPlaces(Place place)
        {
            SystemOperationBase so = new GetAllPlacesSO();
            so.ExecuteTemplate(place);
            return (List<Place>)so.Result;
        }

        public List<Questionnaire> GetAllQuestionnaires(Questionnaire questionnaire)
        {
            SystemOperationBase so = new GetAllQuestionnairesSO();
            so.ExecuteTemplate(questionnaire);
            return (List<Questionnaire>)so.Result;
        }

        public List<Volunteer> GetAllVolunteers(Volunteer volunteer)
        {
            SystemOperationBase so = new GetAllVolunteersSO();
            so.ExecuteTemplate(volunteer);
            return (List<Volunteer>)so.Result;
        }

        public List<CallToDonor> GetDonorCalls(BloodTransfAction action)
        {
            SystemOperationBase so = new GetAllDonorCallsSO();
            so.ExecuteTemplate(action);
            return (List<CallToDonor>)so.Result;
        }

        public List<Donor> GetFilteredDonors(Donor donor)
        {
            SystemOperationBase so = new FindDonorsSO();
            so.ExecuteTemplate(donor);
            return (List<Donor>)so.Result;
        }

        public List<Volunteer> GetFilteredVolunteers(Volunteer volunteer)
        {
            SystemOperationBase so = new FindVolunteersSO();
            so.ExecuteTemplate(volunteer);
            return (List<Volunteer>)so.Result;
        }

        public List<CallToVolunteer> GetVolunteerCalls(BloodTransfAction action)
        {
            SystemOperationBase so = new GetAllVolunteerCallsSO();
            so.ExecuteTemplate(action);
            return (List<CallToVolunteer>)so.Result;
        }

        public BloodTransfAction LoadAction(BloodTransfAction bloodTransfAction)
        {
            SystemOperationBase so = new LoadActionSO();
            so.ExecuteTemplate(bloodTransfAction);
            return (BloodTransfAction)so.Result;
        }

        public Volunteer LoadVolunteer(Volunteer volunteer)
        {
            SystemOperationBase so = new LoadVolunteerSO();
            so.ExecuteTemplate(volunteer);
            return (Volunteer)so.Result;
        }

        public TransfusionCenterCoordinator Login(TransfusionCenterCoordinator coord)
        {           
            SystemOperationBase so = new LoginSO();
            so.ExecuteTemplate(coord);
            return (TransfusionCenterCoordinator)so.Result;
        }

        public void UpdateCallToAction(BloodTransfAction action)
        {
            SystemOperationBase so = new UpdateCallToActionSO();
            so.ExecuteTemplate(action);
        }

        public void UpdateDonor(Donor donor)
        {
            SystemOperationBase so = new UpdateDonorSO();
            so.ExecuteTemplate(donor);           
        }
    }
}
