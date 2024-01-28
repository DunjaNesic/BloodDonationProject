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
    public class DonorGuiController
    {
        private static DonorGuiController _instance;
        public static DonorGuiController Instance { get { if (_instance == null) _instance = new DonorGuiController(); return _instance; } }
        UCDonors uCDonors;
        UCCreateDonor uCCreateDonor;
        UCUpdateDonor uCUpdateDonor;

        FrmMainScreen _frmMain;
        public List<Place> listOfPlaces = new List<Place>();

        public List<Donor> donors = new List<Donor>();
        public BindingList<Donor> listOfDonors = new BindingList<Donor>();

        public Donor donorToUpdate;

        public List<Questionnaire> listOfQuestionnaires = new List<Questionnaire>();
        internal void ShowUCDonor(FrmMainScreen frmMain, FormMode mode)
        {
            _frmMain = frmMain;
            if (mode == FormMode.View)
            {
                uCDonors = new UCDonors();
                frmMain.ChangePanel(uCDonors);

                uCDonors.BtnAddNewDonor.Click += BtnAddNewDonor_Click;
                uCDonors.BtnDeleteDonor.Click += BtnDeleteDonor_Click;
                uCDonors.BtnUpdateDonorInfo.Click += BtnUpdateDonorInfo_Click;
                uCDonors.BtnFindDonor.Click += BtnFindDonor_Click;

                GetAllDonors();
            }
            else if (mode == FormMode.Add)
            {
                AddNewDonor();
            }
        }

        private void BtnFindDonor_Click(object sender, EventArgs e)
        {
            try
            {
                string filter = uCDonors.TxtFindDonor.Text;
                if (filter.Length > 0)
                {
                    string filterCondition = $"lower(d.JMBG) = '{filter.ToLower()}'";
                    Donor filteredDonor = Communication.Instance.FilterDonor(filterCondition);

               
                    List<Donor> filteredDonors = new List<Donor>();

                    if (filteredDonor != null)
                    {
                        filteredDonors.Add(filteredDonor);
                        uCDonors.DgvDonors.DataSource = filteredDonors;
                    }
                    else
                    {
                        
                        uCDonors.DgvDonors.DataSource = null;
                    }
                }
                else
                {
                    GetAllDonors();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetAllDonors()
        {
            donors = Communication.Instance.GetAllDonors();
            listOfDonors = new BindingList<Donor>(donors);
            uCDonors.DgvDonors.DataSource = listOfDonors;
        }
        private void AddNewDonor() {
            uCCreateDonor = new UCCreateDonor();
            _frmMain.ChangePanel(uCCreateDonor);

            listOfPlaces = Communication.Instance.GetAllPlaces();
            uCCreateDonor.CmbPlaces.DataSource = listOfPlaces;
            uCCreateDonor.CmbBloodType.DataSource = Enum.GetValues(typeof(BloodType));

            uCCreateDonor.BtnCreateDonor.Click += BtnCreateDonor_Click;
        }

        private void BtnCreateDonor_Click(object sender, EventArgs e)
        {
            string JMBG = uCCreateDonor.TxtJMBG.Text;
            string[] fullName = uCCreateDonor.TxtDonorNameSurname.Text.Split(' ');
            string name = fullName[0];
            string surname = fullName[1];
            string contact = uCCreateDonor.TxtContact.Text;
            DateTime lastDonation = uCCreateDonor.MonthCalendar1.SelectionStart;
            Place place = (Place)uCCreateDonor.CmbPlaces.SelectedItem;
            BloodType bloodType = (BloodType)uCCreateDonor.CmbBloodType.SelectedItem;
            
            Donor donor = Communication.Instance.CreateDonor(new Donor() { 
            JMBG = JMBG,
            DonorName = name,
            DonorLastName = surname,
            BloodType = bloodType,
            DonorContact = contact,
            LastDonationDate = lastDonation,
            IsActive = (IsActive)1,
            PlaceID = place.PlaceID
            });
        }

        private void BtnUpdateDonorInfo_Click(object sender, EventArgs e)
        {
            donorToUpdate = (Donor)uCDonors.DgvDonors.SelectedRows[0].DataBoundItem;

            uCUpdateDonor = new UCUpdateDonor();
            _frmMain.ChangePanel(uCUpdateDonor);
            uCUpdateDonor.LabelJmbg.Text = donorToUpdate.JMBG;
            uCUpdateDonor.CmbIsActive.DataSource = Enum.GetValues(typeof(IsActive));

            listOfQuestionnaires = Communication.Instance.GetAllQuestionnaires(donorToUpdate);
            uCUpdateDonor.DgvQuestionnaires.DataSource = listOfQuestionnaires;


            uCUpdateDonor.BtnUpdateDonor.Click += BtnUpdateDonor_Click;
        }

        private void BtnUpdateDonor_Click(object sender, EventArgs e)
        {
            string[] fullName = uCUpdateDonor.TxtDonorNameSurname.Text.Split(' ');
            string name = fullName[0];
            string surname = fullName[1];
            string contact = uCUpdateDonor.TxtContact.Text;
            DateTime lastDonation = uCUpdateDonor.MonthCalendar1.SelectionStart;
            IsActive isActive = (IsActive)uCUpdateDonor.CmbIsActive.SelectedItem;
            donorToUpdate.DonorName = name;
            donorToUpdate.DonorLastName = surname;
            donorToUpdate.DonorContact = contact;
            donorToUpdate.LastDonationDate = lastDonation;
            donorToUpdate.IsActive = isActive;

            bool updated = Communication.Instance.UpdateDonor(donorToUpdate);
        }

        private void BtnDeleteDonor_Click(object sender, EventArgs e)
        {
            Donor selectedDonor = (Donor)uCDonors.DgvDonors.SelectedRows[0].DataBoundItem;
            bool deleted = Communication.Instance.DeleteDonor(selectedDonor);
            if (deleted)
            {
                donors.Remove(selectedDonor);
                listOfDonors.ResetBindings();
            }
            else
            {
                MessageBox.Show("Neuspesno");
            }
        }

        private void BtnAddNewDonor_Click(object sender, EventArgs e)
        {
            AddNewDonor();
        }
    }
}
