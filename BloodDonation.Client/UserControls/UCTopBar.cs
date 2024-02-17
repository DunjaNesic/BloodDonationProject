using BloodDonation.Client.GUIController;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodDonation.Client.UserControls
{
    public partial class UCTopBar : UserControl
    {

        public event EventHandler Minimize;
        public event EventHandler LeaveApp;

        public UCTopBar()
        {
            InitializeComponent();
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            Minimize?.Invoke(this, EventArgs.Empty);         
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LeaveApp?.Invoke(this, EventArgs.Empty);           
        }
    }
}
