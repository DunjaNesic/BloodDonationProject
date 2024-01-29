using BloodDonation.Client.GUIController;
using BloodDonation.Client.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodDonation.Client.Forms
{
    public partial class FrmLogin : Form
    {
      
        private LoginGuiController _loginGuiController;

        public FrmLogin()
        {
            InitializeComponent();           
        }
        public FrmLogin(LoginGuiController loginGuiController)
        {
            InitializeComponent();
            _loginGuiController = loginGuiController;
            btnLogin.Click += _loginGuiController.Login;
        }
    }
}
