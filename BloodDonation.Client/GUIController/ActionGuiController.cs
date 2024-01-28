using BloodDonation.Client.ClientCommunication;
using BloodDonation.Client.Forms;
using BloodDonation.Client.UserControls;
using BloodDonation.Common.Domain;
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
       
        UCCallToAction uCCallToAction;
        UCUpdateCallToAction uCUpdateCallToAction;

        FrmMainScreen _frmMain;

        public List<BloodTransfAction> actions = new List<BloodTransfAction>();
        public List<Donor> donors = new List<Donor>();
        public List<Volunteer> volunteers = new List<Volunteer>();
        internal void ShowUCCallToAction(FrmMainScreen frmMain, FormMode mode)
        {
            _frmMain = frmMain;
            if (mode == FormMode.Add)
            {
                uCCallToAction = new UCCallToAction();
                _frmMain.ChangePanel(uCCallToAction);

                volunteers = Communication.Instance.GetAllVolunteers();
                donors = Communication.Instance.GetAllDonors();
                actions = Communication.Instance.GetAllActions();

                uCCallToAction.CmbActions.DataSource = actions;
                uCCallToAction.CheckedListBoxVolunteers.Items.AddRange(volunteers.ToArray());
                uCCallToAction.CheckedListBoxDonors.Items.AddRange(donors.ToArray());

            }
            else if (mode == FormMode.Update) 
            { 
                uCUpdateCallToAction = new UCUpdateCallToAction();
                _frmMain.ChangePanel(uCUpdateCallToAction);
            }
        }




    }
}
