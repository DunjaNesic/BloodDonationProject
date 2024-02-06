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
        UCDetailsDonor uCDetailsDonor;
    
        public List<Place> listOfPlaces = new List<Place>();

        public List<Donor> donors = new List<Donor>();
        public BindingList<Donor> listOfDonors = new BindingList<Donor>();

        Donor loadedDonor = new Donor();

        public List<Questionnaire> listOfQuestionnaires = new List<Questionnaire>();
        internal UserControl ShowUCDonor(FormMode mode)
        {
            if (mode == FormMode.View)
            {
                uCDonors = new UCDonors();

                uCDonors.ToolStripVolunteers1.Click += (s, a) => MainCoordinator.Instance.ShowVolunteerScreen(FormMode.View);
                uCDonors.ToolStripActions1.Click += (s, a) => MainCoordinator.Instance.ShowActionScreen(FormMode.View);

                uCDonors.BtnAddNewDonor.Click += BtnAddNewDonor_Click;
                uCDonors.BtnFindDonor.Click += BtnFindDonor_Click;

                GetAllDonors();

                return uCDonors;
            }
            else if (mode == FormMode.Add)
            {
                uCDetailsDonor = new UCDetailsDonor();

                listOfPlaces = Communication.Instance.GetAllPlaces();
                uCDetailsDonor.CmbPlaces.DataSource = listOfPlaces;
                uCDetailsDonor.CmbBloodType.DataSource = Enum.GetValues(typeof(BloodType));
                uCDetailsDonor.CmbIsActive.DataSource = Enum.GetValues(typeof(IsActive));
                uCDetailsDonor.BtnDeleteDonor.Visible = false;
                uCDetailsDonor.BtnUpdateDonor.Visible = false;
                uCDetailsDonor.DgvQuestionnaires.Visible = false;
                uCDetailsDonor.LblQuest.Visible = false;
                uCDetailsDonor.LblIsActive.Visible = false;
                uCDetailsDonor.CmbIsActive.Visible = false;
                uCDetailsDonor.BtnGoBack.Click += BtnGoBack_Click;

                uCDetailsDonor.BtnCreateDonor.Click += BtnCreateDonor_Click;

                return uCDetailsDonor;
            }
            else if (mode == FormMode.Details) 
            {
                uCDetailsDonor = new UCDetailsDonor();

                listOfPlaces = Communication.Instance.GetAllPlaces();
                uCDetailsDonor.CmbPlaces.DataSource = listOfPlaces;
                uCDetailsDonor.CmbBloodType.DataSource = Enum.GetValues(typeof(BloodType));
                uCDetailsDonor.CmbIsActive.DataSource = Enum.GetValues(typeof(IsActive));
                uCDetailsDonor.TxtJMBG.Enabled = false;
                uCDetailsDonor.TxtJMBG.Text = loadedDonor.JMBG;
                uCDetailsDonor.BtnCreateDonor.Visible = false;
                uCDetailsDonor.BtnGoBack.Click += BtnGoBack_Click;


                listOfQuestionnaires = Communication.Instance.GetAllQuestionnaires(loadedDonor);
                uCDetailsDonor.DgvQuestionnaires.DataSource = listOfQuestionnaires;


                uCDetailsDonor.BtnUpdateDonor.Click += BtnUpdateDonor_Click;
                uCDetailsDonor.BtnDeleteDonor.Click += BtnDeleteDonor_Click;

                return uCDetailsDonor;
            }
            return uCDonors;
        }

        private void BtnGoBack_Click(object sender, EventArgs e)
        {
            try
            {
                MainCoordinator.Instance.ShowDonorScreen(FormMode.View);
            }
            catch (ServerCommunicationException ex)
            {
                MessageBox.Show(ex.ErrorMessage);
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
                    loadedDonor = Communication.Instance.FilterDonor(filterCondition);
                   

                    if (loadedDonor != null)
                    {
                        MainCoordinator.Instance.ShowDonorScreen(FormMode.Details);                 
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
                MessageBox.Show(ex.ErrorMessage);
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
        private void BtnCreateDonor_Click(object sender, EventArgs e)
        {
            bool successful = true;
            bool serverException = false;
            try
            {
                string JMBG = uCDetailsDonor.TxtJMBG.Text;

                if (JMBG.Length != 13 || !IsNumeric(JMBG))
                {
                    MessageBox.Show("JMBG mora sadržati tačno 13 brojeva");
                    successful = false;
                    return;
                }

                string[] fullName = uCDetailsDonor.TxtDonorNameSurname.Text.Split(' ');

                if (fullName.Length != 2)
                {
                    MessageBox.Show("Molimo vas da unesete i ime i prezime odvojene razmakom");
                    successful = false;
                    return;
                }

                string name = fullName[0];
                string surname = fullName[1];

                string contact = uCDetailsDonor.TxtContact.Text;
                DateTime lastDonation = uCDetailsDonor.MonthCalendar1.SelectionStart;

                if (lastDonation > DateTime.Now)
                {
                    MessageBox.Show("Datum poslednjeg davanja krvi ne može biti u budućnosti");
                    successful = false;
                    return;
                }

                Place place = (Place)uCDetailsDonor.CmbPlaces.SelectedItem;

                if (place == null)
                {
                    MessageBox.Show("Molimo vas da izaberete mesto");
                    successful = false;
                    return;
                }

                BloodType bloodType = (BloodType)uCDetailsDonor.CmbBloodType.SelectedItem;

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
                MessageBox.Show(ex.ErrorMessage);
                successful = false;
                serverException = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                successful = false;
            }
            finally
            {
                if (!serverException) { 
                    DialogResult finallyResult = MessageBox.Show("Da li želite nastaviti sa dodavanjem donora?", "Nastavi dodavanje", MessageBoxButtons.YesNo);

                if (finallyResult == DialogResult.No)
                {
                    MainCoordinator.Instance.ShowDonorScreen(FormMode.View);
                }
                else
                {
                    if (successful) 
                    {
                        uCDetailsDonor.TxtJMBG.Text = string.Empty;
                        uCDetailsDonor.TxtDonorNameSurname.Text = string.Empty;
                        uCDetailsDonor.TxtContact.Text = string.Empty;
                        uCDetailsDonor.MonthCalendar1.SelectionStart = DateTime.Now;
                        uCDetailsDonor.CmbPlaces.SelectedIndex = -1;
                        uCDetailsDonor.CmbBloodType.SelectedIndex = -1;
                    }

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
        private void BtnUpdateDonor_Click(object sender, EventArgs e)
        {
            try
            {
                string[] fullName = uCDetailsDonor.TxtDonorNameSurname.Text.Split(' ');

                if (fullName.Length != 2)
                {
                    MessageBox.Show("Ime i prezime davaoca mora biti uneto u formatu Ime Prezime");
                    DialogResult result = MessageBox.Show("Želite li da nastavite sa ažuriranjem davaoca?", "Nastavi?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.No)
                    {
                        MainCoordinator.Instance.ShowDonorScreen(FormMode.View);
                    }
                    return;
                }

                string name = fullName[0];
                string surname = fullName[1];

                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(surname))
                {
                    MessageBox.Show("Polje za ime i prezime ne sme biti prazno");
                    DialogResult result = MessageBox.Show("Želite li da nastavite sa ažuriranjem davaoca?", "Nastavi?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.No)
                    {
                        MainCoordinator.Instance.ShowDonorScreen(FormMode.View);
                    }
                    return;
                }

                string contact = uCDetailsDonor.TxtContact.Text;

                if (string.IsNullOrWhiteSpace(contact))
                {
                    MessageBox.Show("Morate upisati kontakt davaoca");
                    DialogResult result = MessageBox.Show("Želite li da nastavite sa ažuriranjem davaoca?", "Nastavi?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.No)
                    {
                        MainCoordinator.Instance.ShowDonorScreen(FormMode.View);
                    }
                    return;
                }

                DateTime lastDonation = uCDetailsDonor.MonthCalendar1.SelectionStart;

                if (lastDonation > DateTime.Now)
                {
                    MessageBox.Show("Datum poslednjeg davanja krvi ne može biti u budućnosti");
                    DialogResult result = MessageBox.Show("Želite li da nastavite sa ažuriranjem davaoca?", "Nastavi?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.No)
                    {
                        MainCoordinator.Instance.ShowDonorScreen(FormMode.View);
                    }
                    return;
                }

                IsActive isActive = (IsActive)uCDetailsDonor.CmbIsActive.SelectedItem;
   
                loadedDonor.DonorName = name;
                loadedDonor.DonorLastName = surname;
                loadedDonor.DonorContact = contact;
                loadedDonor.LastDonationDate = lastDonation;
                loadedDonor.IsActive = isActive;

                Communication.Instance.UpdateDonor(loadedDonor);
                MainCoordinator.Instance.ShowDonorScreen(FormMode.View);
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.ErrorMessage);
            }
            catch (ServerCommunicationException ex)
            {
                MessageBox.Show(ex.ErrorMessage);
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
                Communication.Instance.DeleteDonor(loadedDonor);
                donors.Remove(loadedDonor);
                listOfDonors.ResetBindings();

                MainCoordinator.Instance.ShowDonorScreen(FormMode.View);
            }
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.ErrorMessage);             
            }
            catch (ServerCommunicationException ex)
            {
                MessageBox.Show(ex.ErrorMessage);            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);            
            }                     
          
        }
        private void BtnAddNewDonor_Click(object sender, EventArgs e)
        {
            try
            {
                MainCoordinator.Instance.ShowDonorScreen(FormMode.Add);
            }
            catch (ServerCommunicationException ex)
            {
                MessageBox.Show(ex.ErrorMessage);
            }
        }
    }
}
