using BloodDonation.Client.ClientCommunication;
using BloodDonation.Client.Exceptions;
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
        private TransfusionCenterCoordinator _coordinator = new TransfusionCenterCoordinator();
        FrmLogin _frmLogin;
        internal void ShowFrmLogin()
        {
            _frmLogin = new FrmLogin(this);
            Application.Run(_frmLogin);
        }
        public void Login(object sender, EventArgs e)
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
                MessageBox.Show(ex.Message);
            }

        }

    }
}