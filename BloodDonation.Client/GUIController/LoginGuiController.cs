using BloodDonation.Client.ClientCommunication;
using BloodDonation.Client.Forms;
using BloodDonation.Common.Communication;
using BloodDonation.Common.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodDonation.Client.GUIController
{
    public class LoginGuiController
    {
        private static LoginGuiController _instance;
        public static LoginGuiController Instance { get { if (_instance == null) _instance = new LoginGuiController(); return _instance; } }
        private TransfusionCenterCoordinator _coordinator = new TransfusionCenterCoordinator();
        FrmLogin _frmLogin;
        internal void ShowFrmLogin()
        {
            _frmLogin = new FrmLogin();
            Application.Run(_frmLogin);
        }

        public void Login(object sender, EventArgs e)
        {
            if (Communication.Instance.Connect())
            {
                string coordinatorCode = _frmLogin.TxtCoordinatorCode.Text;
                string password = _frmLogin.TxtPassword.Text;

                _coordinator = Communication.Instance.LoginCoord(coordinatorCode, password);
                if (_coordinator != null)
                {
                    MainCoordinator.Instance.coord = _coordinator;
                    MainCoordinator.Instance.ShowMainScreen();
                }
                else
                {
                    MessageBox.Show("Ne postoji koordinator akcije sa unetim kredencijalima");
                }
            }
            else
            {
                MessageBox.Show("Povezivanje na server je neuspešno");
            }
        
        }

    }
}