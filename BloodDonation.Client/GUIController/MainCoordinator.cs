using BloodDonation.Client.Forms;
using BloodDonation.Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        internal void ShowLoginScreen()
        {
            LoginGuiController.Instance.ShowFrmLogin();
        }

        internal void ShowMainScreen()
        {
            frmMain = new FrmMainScreen();
            frmMain.LblCoordinator.Text = coord.CoordinatorName + " " + coord.CoordinatorLastName;
            frmMain.Show();
            //Application.Run(frmMain);
        }
        internal void ShowVolunteerScreen(FormMode mode)
        {
            VolunteerGuiController.Instance.ShowUCVolunteer(frmMain, mode);
        }

        internal void ShowDonorScreen(FormMode mode)
        {
            DonorGuiController.Instance.ShowUCDonor(frmMain, mode);
        }

        internal void ShowActionScreen(FormMode mode)
        {
            ActionGuiController.Instance.ShowUCCallToAction(frmMain, mode);
        }

      
    }
}
