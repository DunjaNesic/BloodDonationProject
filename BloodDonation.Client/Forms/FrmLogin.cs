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
        public FrmLogin()
        {
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();

            this.ucTopBar.LeaveApp += UcTopBar_LeaveApp;
            this.ucTopBar.Minimize += UcTopBar_Minimize;
        }

        private void UcTopBar_Minimize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;           
        }

        private void UcTopBar_LeaveApp(object sender, EventArgs e)
        {
            MainCoordinator.Instance.CloseLoginForm(this);
        }
    }
}
