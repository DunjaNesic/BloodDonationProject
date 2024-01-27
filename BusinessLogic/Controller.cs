using BloodDonation.Common.Domain;
using BloodDonation.Repository.Implementation;
using BloodDonation.Repository.Interfaces;
using BloodDonation.SystemOperations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Controller
    {
        private static Controller _instance;
        public static Controller Instance { get { if (_instance == null) _instance = new Controller(); return _instance; } }

        public Volunteer CreateNewVolunteer(Volunteer volunteer)
        {
            SystemOperationBase so = new AddVolunteerSO();
            so.ExecuteTemplate(volunteer);
            return (Volunteer)so.Result;
        }

        public bool DeleteVolunteer(Volunteer volunteer)
        {
            SystemOperationBase so = new DeleteVolunteerSO();
            so.ExecuteTemplate(volunteer);
            return (bool)so.Result;
        }

        public List<Place> GetAllPlaces(Place place)
        {
            SystemOperationBase so = new GetAllPlacesSO();
            so.ExecuteTemplate(place);
            return (List<Place>)so.Result;
        }

        public List<Volunteer> GetAllVolunteers(Volunteer volunteer)
        {
            SystemOperationBase so = new GetAllVolunteersSO();
            so.ExecuteTemplate(volunteer);
            return (List<Volunteer>)so.Result;
        }

        public List<Volunteer> GetFilteredVolunteers(Volunteer volunteer)
        {
            SystemOperationBase so = new FindVolunteersSO();
            so.ExecuteTemplate(volunteer);
            return (List<Volunteer>)so.Result;
        }

        public TransfusionCenterCoordinator Login(TransfusionCenterCoordinator coord)
        {           
            SystemOperationBase so = new LoginSO();
            so.ExecuteTemplate(coord);
            return (TransfusionCenterCoordinator)so.Result;
        }


    }
}
