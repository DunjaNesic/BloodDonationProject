using BloodDonation.Client.Forms;
using BloodDonation.Common.Domain;
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

        public TransfusionCenterCoordinator coord;

        private VolunteerGuiController _volunteerGuiController;
        private DonorGuiController _donorGuiController;
        private ActionGuiController _actionGuiController;

        FrmMainScreen frmMain;

        internal void showLoginScreen() { 
            LoginGuiController.Instance.showFrmLogin();
        }

        internal void showMainScreen() { 
            frmMain = new FrmMainScreen();
            frmMain.LblCoordinator.Text = coord.CoordinatorName + " " + coord.CoordinatorLastName;
            frmMain.Show();
        }
        internal void showVolunteerScreen(FormMode mode)
        {
            VolunteerGuiController.Instance.showUCVolunteer(frmMain, mode);
        }

        internal void showDonorScreen(FormMode mode)
        {
            DonorGuiController.Instance.showUCDonor(frmMain, mode);
        }

        internal void showActionScreen()
        {
            ActionGuiController.Instance.showUCCallToAction(frmMain);
        }
    }
}
