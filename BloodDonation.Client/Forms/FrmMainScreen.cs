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
    public partial class FrmMainScreen : Form
    {
        public FrmMainScreen()
        {
            InitializeComponent();
            toolStripVolunteers.Click += (s, a) => MainCoordinator.Instance.showVolunteerScreen();
            toolStripDonors.Click += (s, a) => MainCoordinator.Instance.showDonorScreen();
            toolStripActions.Click += (s, a) => MainCoordinator.Instance.showActionScreen();
        }

        public void ChangePanel(UserControl control)
        {      
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(control);
            control.Dock = DockStyle.Fill;
            pnlMain.AutoSize = true;
            pnlMain.AutoSizeMode = AutoSizeMode.GrowAndShrink;
        }
    }
}
