using BloodDonation.Client.ClientCommunication;
using BloodDonation.Client.Exceptions;
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
        public List<Place> listOfPlaces = new List<Place>();
        public List<Volunteer> volunteers = new List<Volunteer>();
        public BindingList<Volunteer> listOfVolunteers = new BindingList<Volunteer>();
        Volunteer loadedVol = new Volunteer();
        UCVolunteers uCVolunteers;
        UCCreateVolunteer uCCreateVolunteer;
        internal UserControl ShowUCVolunteer(FormMode mode)
        {           
            if (mode == FormMode.View)
            {
                uCVolunteers = new UCVolunteers();               

                uCVolunteers.BtnAddNewVolunteer.Click += BtnAddNewVolunteer_Click;
                uCVolunteers.BtnDeleteVolunteer.Click += BtnDeleteVolunteer_Click;
                uCVolunteers.TxtFilterVolunteers.TextChanged += TxtFilterVolunteers_TextChanged;

                uCVolunteers.ToolStripActions1.Click += (s, a) => MainCoordinator.Instance.ShowActionScreen(FormMode.View);
                uCVolunteers.ToolStripDonors1.Click += (s, a) => MainCoordinator.Instance.ShowDonorScreen(FormMode.View);

                GetAllVolunteers();
                return uCVolunteers;
            }
            else if (mode == FormMode.Add) {
                uCCreateVolunteer.BtnGoBack.Click += BtnGoBack_Click;
                return uCCreateVolunteer;
            }
            return uCVolunteers;
        }

        private void BtnGoBack_Click(object sender, EventArgs e)
        {
            try
            {
                MainCoordinator.Instance.ShowVolunteerScreen(FormMode.View);
            }
            catch (ServerCommunicationException ex)
            {
                MessageBox.Show(ex.ErrorMessage);
            }
        }
        private void TxtFilterVolunteers_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string filter = uCVolunteers.TxtFilterVolunteers.Text;
                if (filter.Length > 0)
                {
                    string filterCondition = $" lower(v.VolunteerName) like '{filter}%' or " +
                        $"lower(v.VolunteerLastName) like '{filter}%' or lower(p.PlaceName) like" +
                        $" '%{filter}%' ";
                    List<Volunteer> filteredVolunteers = Communication.Instance.FilterVolunteers(filterCondition);
                    uCVolunteers.DgvVolunteers.DataSource = filteredVolunteers;
                }
                else
                {
                    GetAllVolunteers();
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

        private void BtnCreateVolunteer_Click(object sender, EventArgs e)
        {
            bool serverException = false;
            try
            {
                string[] fullName = uCCreateVolunteer.TxtVolunteerNameSurname.Text.Split(' ');
                if (fullName.Length != 2)
                {
                    MessageBox.Show("Ime i prezime volontera mora biti uneto u formatu Ime Prezime");
                    return;
                }

                string name = fullName[0];
                string surname = fullName[1];

                DateTime dateFrom = uCCreateVolunteer.MonthCalendar1.SelectionStart;
                DateTime dateTo = uCCreateVolunteer.MonthCalendar2.SelectionStart;
                if (dateFrom > dateTo)
                {
                    MessageBox.Show("Datum OD ne sme biti nakon datuma DO");
                    return;
                }

                if (uCCreateVolunteer.CmbPlaces.SelectedItem == null)
                {
                    MessageBox.Show("Grad mora biti izabran");
                    return;
                }

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
            catch (SystemOperationException ex)
            {
                MessageBox.Show(ex.ErrorMessage);
            }
            catch (ServerCommunicationException ex)
            {
                MessageBox.Show(ex.ErrorMessage);
                serverException = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (!serverException)
                {
                    DialogResult result = MessageBox.Show("Želite li da nastavite sa dodavanjem volontera?", "Nastavi?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.No)
                    {
                        MainCoordinator.Instance.ShowVolunteerScreen(FormMode.View);
                    }
                }
            }
        }

        private void AddNewVolunteer() {
            uCCreateVolunteer = new UCCreateVolunteer();            

            uCCreateVolunteer.BtnCreateVolunteer.Click += BtnCreateVolunteer_Click;

            listOfPlaces = Communication.Instance.GetAllPlaces();
            uCCreateVolunteer.CmbPlaces.DataSource = listOfPlaces;

            MainCoordinator.Instance.ShowVolunteerScreen(FormMode.Add);

        }
        private void GetAllVolunteers() {
            volunteers = Communication.Instance.GetAllVolunteers();
            listOfVolunteers = new BindingList<Volunteer>(volunteers);
            uCVolunteers.DgvVolunteers.DataSource = listOfVolunteers;
        }   
        private void BtnDeleteVolunteer_Click(object sender, EventArgs e)
        {            
            try
            {
                if (uCVolunteers.DgvVolunteers.SelectedRows.Count != 1)
                {
                    MessageBox.Show("Nema izabranog volontera za brisanje");
                    return;
                }
                Volunteer selectedVol = (Volunteer)uCVolunteers.DgvVolunteers.SelectedRows[0].DataBoundItem;
                loadedVol = Communication.Instance.GetVolunteer(selectedVol.VolunteerID);

                if (loadedVol != null)
                {
                    Communication.Instance.DeleteVolunteer(loadedVol);

                    volunteers.Remove(volunteers.Find(v => v.VolunteerID == loadedVol.VolunteerID));

                    listOfVolunteers.ResetBindings();
                    loadedVol = null;
                    uCVolunteers.DgvVolunteers.DataSource = listOfVolunteers;
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

        private void BtnAddNewVolunteer_Click(object sender, EventArgs e)
        {
            AddNewVolunteer();
        }
    }
}
