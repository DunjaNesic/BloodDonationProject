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
        public TransfusionCenterCoordinator Login(TransfusionCenterCoordinator coord)
        {           
            SystemOperationBase so = new LoginSO();
            so.ExecuteTemplate(coord);
            return (TransfusionCenterCoordinator)so.Result;
        }


    }
}
