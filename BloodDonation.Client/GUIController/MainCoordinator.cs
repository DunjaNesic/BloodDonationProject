using BloodDonation.Client.ClientCommunication;
using BloodDonation.Client.Exceptions;
using BloodDonation.Client.Forms;
using BloodDonation.Common.Domain;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        public FrmMainScreen _frmMain;
        public FrmLogin _frmLogin;     
        internal void ShowMainScreen()
        {
            _frmMain = new FrmMainScreen();
            _frmMain.LblCoordinator.Text = "Trenutno ulogovan koordinator: " + coord.CoordinatorName + " " + coord.CoordinatorLastName;

            _frmLogin.Visible = false;
            _frmMain.ShowDialog();
            _frmLogin.Visible = true;
        }
        public void FirstLogin()
        {
            try
            {
                _loginGuiController.CreateLogin(_frmLogin);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(">>>" + ex.Message);
            }
        }

        public void CloseLoginForm(Form parentForm) {
            if (parentForm != null && parentForm is FrmMainScreen)
            {
                CloseMainForm();
            }
            else {
                Application.Exit();
            }
        }
        public void CloseMainForm() {
            try
            {
                coord = null;
                _frmMain.Dispose();
                Communication.Instance.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(">>>>>>>" + ex.Message + "closing main form");
            }
        }

        internal void ShowVolunteerScreen(FormMode mode)
        {
            try
            {
                _frmMain.ChangePanel(_volunteerGuiController.ShowUCVolunteer(mode));
            }
            catch (ServerCommunicationException ex)
            {
                MessageBox.Show(ex.ErrorMessage);
            }

            //znaci boze gospode
            //VolunteerGuiController.Instance.ShowUCVolunteer(frmMain, mode);
        }

        internal void ShowDonorScreen(FormMode mode)
        {
            try
            {
                _frmMain.ChangePanel(_donorGuiController.ShowUCDonor(mode));
            }
            catch (ServerCommunicationException ex)
            {
                MessageBox.Show(ex.ErrorMessage);
            }
        }

        internal void ShowActionScreen(FormMode mode)
        {
            try
            {
                _frmMain.ChangePanel(_actionGuiController.ShowUCCallToAction(mode));
            }
            catch (ServerCommunicationException ex)
            {
                MessageBox.Show(ex.ErrorMessage);
            }
        }

       
    }
}
