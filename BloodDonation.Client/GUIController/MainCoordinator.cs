using BloodDonation.Client.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.Client.GUIController
{
    public class MainCoordinator
    {
        private static MainCoordinator _instance;
        public static MainCoordinator Instance { get { if (_instance == null) _instance = new MainCoordinator(); return _instance; } }

        private MainCoordinator()
        {
            _volunteerGuiController = new VolunteerGuiController();
            _donorGuiController = new DonorGuiController();
            _actionGuiController = new ActionGuiController();   
        }

        private VolunteerGuiController _volunteerGuiController;
        private DonorGuiController _donorGuiController;
        private ActionGuiController _actionGuiController;

        internal void showVolunteerScreen()
        {
           
        }

        internal void showDonorScreen()
        {
            throw new NotImplementedException();
        }

        internal void showActionScreen()
        {
            throw new NotImplementedException();
        }
    }
}
