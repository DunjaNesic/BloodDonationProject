using BloodDonation.Client.ClientCommunication;
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
        private static readonly object lockobj = new object();

        private static MainCoordinator _instance;
        public static MainCoordinator Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (lockobj)
                    {
                        if (_instance == null)
                        {
                            _instance = new MainCoordinator();
                        }
                    }
                }
                return _instance;
            }
        }

        private MainCoordinator()
        {
            _volunteerGuiController = new VolunteerGuiController();
            _donorGuiController = new DonorGuiController();
            _actionGuiController = new ActionGuiController();
            _loginGuiController = new LoginGuiController();
        }

        public TransfusionCenterCoordinator coord;

        private VolunteerGuiController _volunteerGuiController;
        private DonorGuiController _donorGuiController;
        private ActionGuiController _actionGuiController;
        private LoginGuiController _loginGuiController;

        FrmMainScreen _frmMain;

        internal void ShowLoginScreen()
        {
            _loginGuiController.ShowFrmLogin();
        }

       
        internal void ShowMainScreen()
        {
            _frmMain = new FrmMainScreen();
            _frmMain.LblCoordinator.Text = coord.CoordinatorName + " " + coord.CoordinatorLastName;
            _frmMain.Show();          
        }
        internal void ShowVolunteerScreen(FormMode mode)
        {
            _frmMain.ChangePanel(_volunteerGuiController.ShowUCVolunteer(mode));

            //znaci boze gospode
            //VolunteerGuiController.Instance.ShowUCVolunteer(frmMain, mode);
        }

        internal void ShowDonorScreen(FormMode mode)
        {
            _frmMain.ChangePanel(_donorGuiController.ShowUCDonor(mode));
        }

        internal void ShowActionScreen(FormMode mode)
        {
            _frmMain.ChangePanel(_actionGuiController.ShowUCCallToAction(mode));
        }

      
    }
}
