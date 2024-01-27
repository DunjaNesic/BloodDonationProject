using BloodDonation.Client.Forms;
using BloodDonation.Client.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.Client.GUIController
{
    public class DonorGuiController
    {
        private static DonorGuiController _instance;
        public static DonorGuiController Instance { get { if (_instance == null) _instance = new DonorGuiController(); return _instance; } }

        internal void showUCDonor(FrmMainScreen frmMain, FormMode mode)
        {

            if (mode == FormMode.View)
            {
                UCDonors uCDonors = new UCDonors();
                frmMain.ChangePanel(uCDonors);
            }
            else if (mode == FormMode.Add)
            {
                UCCreateDonor uCCreateDonor = new UCCreateDonor();
                frmMain.ChangePanel(uCCreateDonor);
            }
        }
    }
}
