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
            toolStripVolunteers.Click += (s, a) => MainCoordinator.Instance.ShowVolunteerScreen(FormMode.View);
            toolStripDonors.Click += (s, a) => MainCoordinator.Instance.ShowDonorScreen(FormMode.View);
            toolStripActions.Click += (s, a) => MainCoordinator.Instance.ShowActionScreen(FormMode.View);          
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
