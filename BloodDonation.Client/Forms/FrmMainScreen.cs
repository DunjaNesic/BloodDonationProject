using BloodDonation.Client.GUIController;
using BloodDonation.Client.UserControls;
using BloodDonation.Common.Domain;
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
    public partial class FrmMainScreen : Form
    {     

        public FrmMainScreen()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.FormClosed += FrmMainScreen_FormClosed;
            this.ucTopBar1.LeaveApp += UcTopBar1_LeaveApp;
            this.ucTopBar1.Minimize += UcTopBar1_Minimize;
            toolStripVolunteers.Click += (s, a) => MainCoordinator.Instance.ShowVolunteerScreen(FormMode.View);
            toolStripDonors.Click += (s, a) => MainCoordinator.Instance.ShowDonorScreen(FormMode.View);
            toolStripActions.Click += (s, a) => MainCoordinator.Instance.ShowActionScreen(FormMode.View);          
        }

        private void UcTopBar1_Minimize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void UcTopBar1_LeaveApp(object sender, EventArgs e)
        {            
            MainCoordinator.Instance.CloseLoginForm(this);          
        }

        public void ChangePanel(UserControl control)
        {      
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(control);
            pnlMain.Controls.Add(ucTopBar1);
            control.Dock = DockStyle.Fill;
            ucTopBar1.Dock = DockStyle.Top;       
        }

        private void FrmMainScreen_FormClosed(Object sender, FormClosedEventArgs e)
        {
            MainCoordinator.Instance.CloseMainForm();
        }

    }
}
