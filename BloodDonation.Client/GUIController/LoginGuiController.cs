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
    public class LoginGuiController
    {
        private static LoginGuiController _instance;
        public static LoginGuiController Instance { get { if (_instance == null) _instance = new LoginGuiController(); return _instance; } }

        FrmLogin _frmLogin;
        internal void showFrmLogin() { 
            _frmLogin = new FrmLogin();
            Application.Run(_frmLogin);
        }

        public void Login(object sender, EventArgs e)
        {
            TransfusionCenterCoordinator coordinator = new TransfusionCenterCoordinator
            {
                CoordinatorCode = _frmLogin.TxtCoordinatorCode.Text,
                Password = _frmLogin.TxtPassword.Text,
            };
            //Response response = Communication.Instance.Login(user);
            //if (response.Exception == null)
            //{
            //    _frmLogin.Visible = false;
            //    MainCoordinator.Instance.showMainScreen();
            //}
            //else
            //{
            //    MessageBox.Show(">>>" + response.Exception.ToString());
            //}
        }

    }
}
