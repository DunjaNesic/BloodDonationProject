using BloodDonation.Client.ClientCommunication;
using BloodDonation.Client.Exceptions;
using BloodDonation.Client.Forms;
using BloodDonation.Client.UserControls;
using BloodDonation.Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodDonation.Client.GUIController
{
    public class DonorGuiController
    {       
        UCDonors uCDonors;
        UCCreateDonor uCCreateDonor;
        UCUpdateDonor uCUpdateDonor;

        FrmMainScreen _frmMain;
        public List<Place> listOfPlaces = new List<Place>();

        public List<Donor> donors = new List<Donor>();
        public BindingList<Donor> listOfDonors = new BindingList<Donor>();

        Donor loadedDonor = new Donor();

        public Donor donorToUpdate;

        public List<Questionnaire> listOfQuestionnaires = new List<Questionnaire>();
        internal UserControl ShowUCDonor(FormMode mode)
        {
            if (mode == FormMode.View)
            {
                uCDonors = new UCDonors();

                uCDonors.BtnAddNewDonor.Click += BtnAddNewDonor_Click;
                uCDonors.BtnFindDonor.Click += BtnFindDonor_Click;

                GetAllDonors();

                return uCDonors;
            }
            else if (mode == FormMode.Add)
            {
                return uCCreateDonor;
            }
            else if (mode == FormMode.Details) {
            
            }
            return uCDonors;
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
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.ErrorMessage);
            }
            catch (ServerCommunicationException ex)
            {
                MessageBox.Show(ex.Message);
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

            listOfPlaces = Communication.Instance.GetAllPlaces();
            uCCreateDonor.CmbPlaces.DataSource = listOfPlaces;
            uCCreateDonor.CmbBloodType.DataSource = Enum.GetValues(typeof(BloodType));

            uCCreateDonor.BtnCreateDonor.Click += BtnCreateDonor_Click;

            MainCoordinator.Instance.ShowDonorScreen((FormMode.Add));
        }

        private void BtnCreateDonor_Click(object sender, EventArgs e)
        {
                bool successful = true;
            try
            {
                string JMBG = uCCreateDonor.TxtJMBG.Text;

                if (JMBG.Length != 13 || !IsNumeric(JMBG))
                {
                    MessageBox.Show("JMBG mora sadržavati tačno 13 numeričkih karaktera.");
                    successful = false;
                    return;
                }

                string[] fullName = uCCreateDonor.TxtDonorNameSurname.Text.Split(' ');

                if (fullName.Length != 2)
                {
                    MessageBox.Show("Molimo vas da unesete i ime i prezime odvojene razmakom.");
                    successful = false;
                    return;
                }

                string name = fullName[0];
                string surname = fullName[1];

                string contact = uCCreateDonor.TxtContact.Text;
                DateTime lastDonation = uCCreateDonor.MonthCalendar1.SelectionStart;

                if (lastDonation > DateTime.Now)
                {
                    MessageBox.Show("Datum poslednjeg davanja krvi ne može biti u budućnosti.");
                    successful = false;
                    return;
                }

                Place place = (Place)uCCreateDonor.CmbPlaces.SelectedItem;

                if (place == null)
                {
                    MessageBox.Show("Molimo vas da izaberete mesto.");
                    successful = false;
                    return;
                }

                BloodType bloodType = (BloodType)uCCreateDonor.CmbBloodType.SelectedItem;

                Donor donor = Communication.Instance.CreateDonor(new Donor()
                {
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
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.ErrorMessage);
                successful = false;
            }
            catch (ServerCommunicationException ex)
            {
                MessageBox.Show(ex.Message);
                successful = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                successful = false;
            }
            finally
            {
                DialogResult finallyResult = MessageBox.Show("Da li želite nastaviti sa dodavanjem donora?", "Nastavi dodavanje", MessageBoxButtons.YesNo);

                if (finallyResult == DialogResult.No)
                {
                    MainCoordinator.Instance.ShowDonorScreen(FormMode.View);
                }
                else
                {
                    if (successful)
                    {
                        uCCreateDonor.TxtJMBG.Text = string.Empty;
                        uCCreateDonor.TxtDonorNameSurname.Text = string.Empty;
                        uCCreateDonor.TxtContact.Text = string.Empty;
                        uCCreateDonor.MonthCalendar1.SelectionStart = DateTime.Now; 
                        uCCreateDonor.CmbPlaces.SelectedIndex = -1; 
                        uCCreateDonor.CmbBloodType.SelectedIndex = -1; 
                    }
                   
                }
               
            }
        }
        private bool IsNumeric(string str)
        {
            foreach (char c in str)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
        private void BtnUpdateDonorInfo_Click(object sender, EventArgs e)
        {
            donorToUpdate = (Donor)uCDonors.DgvDonors.SelectedRows[0].DataBoundItem;

            uCUpdateDonor = new UCUpdateDonor();
            _frmMain.ChangePanel(uCUpdateDonor);
            uCUpdateDonor.CmbIsActive.DataSource = Enum.GetValues(typeof(IsActive));

            listOfQuestionnaires = Communication.Instance.GetAllQuestionnaires(donorToUpdate);
            uCUpdateDonor.DgvQuestionnaires.DataSource = listOfQuestionnaires;


            uCUpdateDonor.BtnUpdateDonor.Click += BtnUpdateDonor_Click;
        }

        private void BtnUpdateDonor_Click(object sender, EventArgs e)
        {
            try
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

                Communication.Instance.UpdateDonor(donorToUpdate);
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.ErrorMessage);
            }
            catch (ServerCommunicationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnDeleteDonor_Click(object sender, EventArgs e)
        {
            try
            {
                Donor selectedDonor = (Donor)uCDonors.DgvDonors.SelectedRows[0].DataBoundItem;
                Communication.Instance.DeleteDonor(selectedDonor);
                donors.Remove(selectedDonor);
                listOfDonors.ResetBindings();
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.ErrorMessage);             
            }
            catch (ServerCommunicationException ex)
            {
                MessageBox.Show(ex.Message);            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);            
            }                     
          
        }

        private void BtnAddNewDonor_Click(object sender, EventArgs e)
        {
            AddNewDonor();
        }
    }
}
