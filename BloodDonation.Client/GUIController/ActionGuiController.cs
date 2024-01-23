using BloodDonation.Client.Forms;
using BloodDonation.Client.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.Client.GUIController
{
    public class ActionGuiController
    {
        private static ActionGuiController _instance;
        public static ActionGuiController Instance { get { if (_instance == null) _instance = new ActionGuiController(); return _instance; } }
        internal void showUCCallToAction(FrmMainScreen frmMain)
        {
            UCCallToAction uCCallToAction = new UCCallToAction();
            frmMain.ChangePanel(uCCallToAction);    
        }
    }
}
