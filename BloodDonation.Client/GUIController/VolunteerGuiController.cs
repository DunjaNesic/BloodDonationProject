using BloodDonation.Client.Forms;
using BloodDonation.Client.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodDonation.Client.GUIController
{
    public class VolunteerGuiController
    {
        private static VolunteerGuiController _instance;
        public static VolunteerGuiController Instance { get { if (_instance == null) _instance = new VolunteerGuiController(); return _instance; } }

        internal void showUCVolunteer(FrmMainScreen frmMainScreen, FormMode mode)
        {
            if (mode == FormMode.View)
            {
                UCVolunteers uCVolunteers = new UCVolunteers();
                frmMainScreen.ChangePanel(uCVolunteers);
            }
            else if (mode == FormMode.Add) { 
                UCCreateVolunteer uCCreateVolunteer = new UCCreateVolunteer();
            }
        }

     



    }
}
