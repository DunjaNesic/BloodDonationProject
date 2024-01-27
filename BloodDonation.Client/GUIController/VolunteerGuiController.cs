using BloodDonation.Client.ClientCommunication;
using BloodDonation.Client.Forms;
using BloodDonation.Client.UserControls;
using BloodDonation.Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        FrmMainScreen frmMain;

        public List<Place> listOfPlaces = new List<Place>();
        public List<Volunteer> volunteers = new List<Volunteer>();
        public BindingList<Volunteer> listOfVolunteers = new BindingList<Volunteer>();
        UCVolunteers uCVolunteers;
        UCCreateVolunteer uCCreateVolunteer;
        internal void ShowUCVolunteer(FrmMainScreen frmMainScreen, FormMode mode)
        {
            frmMain = frmMainScreen;
            if (mode == FormMode.View)
            {
                uCVolunteers = new UCVolunteers();
                frmMain.ChangePanel(uCVolunteers);

                uCVolunteers.BtnAddNewVolunteer.Click += BtnAddNewVolunteer_Click;
                uCVolunteers.BtnDeleteVolunteer.Click += BtnDeleteVolunteer_Click;
                uCVolunteers.BtnFilter.Click += BtnFilter_Click;

                GetAllVolunteers();
            }
            else if (mode == FormMode.Add) {
                AddNewVolunteer();
            }
        }        
        private void BtnCreateVolunteer_Click(object sender, EventArgs e)
        {
            string[] fullName = uCCreateVolunteer.TxtVolunteerNameSurname.Text.Split(' ');
            string name = fullName[0];
            string surname = fullName[1];
            DateTime dateFrom = uCCreateVolunteer.MonthCalendar1.SelectionStart;
            DateTime dateTo = uCCreateVolunteer.MonthCalendar2.SelectionStart;
            Place place = (Place)uCCreateVolunteer.CmbPlaces.SelectedItem;         

            Volunteer newVolunteer = Communication.Instance.CreateVolunteer(
                new Volunteer()
                {
                    VolunteerName = name,
                    VolunteerLastName = surname,
                    DateFreeFrom = dateFrom,
                    DateFreeTo = dateTo,
                    Place = place,
                    PlaceID = place.PlaceID
                });
            volunteers.Add(newVolunteer);

        }

        private void AddNewVolunteer() {
            uCCreateVolunteer = new UCCreateVolunteer();
            frmMain.ChangePanel(uCCreateVolunteer);

            uCCreateVolunteer.BtnCreateVolunteer.Click += BtnCreateVolunteer_Click;

            listOfPlaces = Communication.Instance.GetAllPlaces();
            uCCreateVolunteer.CmbPlaces.DataSource = listOfPlaces;
        }
        private void GetAllVolunteers() {
            volunteers = Communication.Instance.GetAllVolunteers();
            listOfVolunteers = new BindingList<Volunteer>(volunteers);
            uCVolunteers.DgvVolunteers.DataSource = listOfVolunteers;
        }
        private void BtnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                string filter = uCVolunteers.TxtSearchVolunteer.Text;
                if (filter.Length > 0)
                {
                    string filterCondition = $" lower(v.VolunteerName) like '%{filter}%' or " +
                        $"lower(v.VolunteerLastName) like '{filter}%' or lower(p.PlaceName) like" +
                        $" '{filter}%' ";
                    List<Volunteer> filteredVolunteers = Communication.Instance.FilterVolunteers(filterCondition);
                    uCVolunteers.DgvVolunteers.DataSource = filteredVolunteers;
                }
                else
                {
                    GetAllVolunteers();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void BtnDeleteVolunteer_Click(object sender, EventArgs e)
        {
            Volunteer selectedVol = (Volunteer)uCVolunteers.DgvVolunteers.SelectedRows[0].DataBoundItem;
            bool deleted = Communication.Instance.DeleteVolunteer(selectedVol);
            if (deleted)
            {
                volunteers.Remove(selectedVol);
                listOfVolunteers.ResetBindings();
            }
            else {
                MessageBox.Show("Neuspesno");
            }
        }

        private void BtnAddNewVolunteer_Click(object sender, EventArgs e)
        {
            AddNewVolunteer();
        }
    }
}
