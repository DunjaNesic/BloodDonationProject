using BloodDonation.Client.ClientCommunication;
using BloodDonation.Client.Exceptions;
using BloodDonation.Client.Forms;
using BloodDonation.Client.UserControls;
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
        private TransfusionCenterCoordinator _coordinator = new TransfusionCenterCoordinator();
        FrmLogin _frmLogin;
        UCTopBar ucNav = new UCTopBar();
        
        public void CreateLogin(FrmLogin frmLogin)
        {
            _frmLogin = frmLogin;
            _frmLogin.BtnLogin.Click += BtnLogin_Click;
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Communication.Instance.Connect();

                string coordinatorCode = _frmLogin.TxtCoordinatorCode.Text;
                string password = _frmLogin.TxtPassword.Text;

                _coordinator = Communication.Instance.LoginCoord(coordinatorCode, password);
           
                MainCoordinator.Instance.coord = _coordinator;
                MainCoordinator.Instance.ShowMainScreen();

            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.ErrorMessage);
            }
            catch (ServerCommunicationException ex)
            {
                MessageBox.Show(ex.ErrorMessage);
            }
        }
       
    }
}