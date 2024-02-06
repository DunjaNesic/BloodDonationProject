using BloodDonation.Client.ClientCommunication;
using BloodDonation.Client.Exceptions;
using BloodDonation.Client.Forms;
using BloodDonation.Client.UserControls;
using BloodDonation.Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodDonation.Client.GUIController
{
    public class ActionGuiController
    {
        UCDetailsCallToAction uCDetailsCallToAction;
        UCCallToAction uCCallToAction;
        BindingList<BloodTransfAction> actionsForDgv = new BindingList<BloodTransfAction>();
        BloodTransfAction action = new BloodTransfAction();
        BloodTransfAction loadedAction;
        List<Place> listOfPlaces = new List<Place>();
        List<Donor> donors = new List<Donor>();
        List<Volunteer> volunteers = new List<Volunteer>();
        List<CallToVolunteer> calledVolunteers;
        List<CallToDonor> calledDonors;
        List<Volunteer> currentVolunteers = new List<Volunteer>();
        List<Donor> currentDonors = new List<Donor>();
        List<Volunteer> filteredVolsByPlace;
        List<Donor> filteredDonorsByPlace;

        internal UserControl ShowUCCallToAction(FormMode mode)
        {
            if (mode == FormMode.View)
            {
                uCCallToAction = new UCCallToAction();
                actionsForDgv = new BindingList<BloodTransfAction>(Communication.Instance.GetAllActions());

                uCCallToAction.ToolStripVolunteers1.Click += (s, a) => MainCoordinator.Instance.ShowVolunteerScreen(FormMode.View);
                uCCallToAction.ToolStripDonors1.Click += (s, a) => MainCoordinator.Instance.ShowDonorScreen(FormMode.View);

                uCCallToAction.DgvActions.DataSource = actionsForDgv;

                uCCallToAction.BtnCreateAction.Click += BtnCreateAction_Click;
                uCCallToAction.BtnUpdateAction.Click += BtnUpdateAction_Click;

                return uCCallToAction;
            }
            else if (mode == FormMode.Add || mode == FormMode.Update)
            {
                uCDetailsCallToAction = new UCDetailsCallToAction();

                InitializeCommonControls();

                if (mode == FormMode.Add)
                {
                    uCDetailsCallToAction.BtnCallToAction.Text = "POZOVI NA AKCIJU";
                    uCDetailsCallToAction.BtnDeleteVolunteer.Visible = false;
                    uCDetailsCallToAction.BtnDeleteDonor.Visible = false;
                    uCDetailsCallToAction.BtnAddDonors.Visible = false;
                    uCDetailsCallToAction.BtnAddVolunteers.Visible = false;
                    uCDetailsCallToAction.DgvCalledDonors.Visible = false;
                    uCDetailsCallToAction.DgvCalledVolunteers.Visible = false;

                    uCDetailsCallToAction.CheckedListBoxVolunteers.Items.AddRange(volunteers.ToArray());
                    uCDetailsCallToAction.CheckedListBoxDonors.Items.AddRange(donors.ToArray());
                    uCDetailsCallToAction.BtnCallToAction.Click += BtnCallToActionAdd_Click;
                }
                else if (mode == FormMode.Update)
                {
                    uCDetailsCallToAction.BtnCallToAction.Text = "AZURIRAJ";
                    uCDetailsCallToAction.BtnDeleteVolunteer.Visible = true;
                    uCDetailsCallToAction.BtnDeleteDonor.Visible = true;
                    uCDetailsCallToAction.BtnAddDonors.Visible = true;
                    uCDetailsCallToAction.BtnAddVolunteers.Visible = true;
                    uCDetailsCallToAction.DgvCalledDonors.Visible = true;
                    uCDetailsCallToAction.DgvCalledVolunteers.Visible = true;

                    uCDetailsCallToAction.BtnAddVolunteers.Click += BtnAddVolunteers_Click;
                    uCDetailsCallToAction.BtnAddDonors.Click += BtnAddDonors_Click;
                    uCDetailsCallToAction.BtnDeleteVolunteer.Click += BtnDeleteVolunteer_Click;
                    uCDetailsCallToAction.BtnDeleteDonor.Click += BtnDeleteDonor_Click;
                    uCDetailsCallToAction.BtnCallToAction.Click += BtnCallToActionUpdate_Click;
                }

                return uCDetailsCallToAction;
            }

            return uCCallToAction;
        }

        private void BtnDeleteDonor_Click(object sender, EventArgs e)
        {
            if (uCDetailsCallToAction.DgvCalledDonors.SelectedRows.Count == 1)
            {
                CallToDonor ctd = (CallToDonor)uCDetailsCallToAction.DgvCalledDonors.SelectedRows[0].DataBoundItem;

                Donor matchingDonor = currentDonors.Find(donor => donor.JMBG == ctd.JMBG);
                if (matchingDonor != null) {
                    matchingDonor.CrudStatus = CrudStatus.Delete;
                }            

                calledDonors.Remove(ctd);
                uCDetailsCallToAction.DgvCalledDonors.DataSource = null;
                uCDetailsCallToAction.DgvCalledDonors.DataSource = calledDonors;
            }
            else
            {
                MessageBox.Show("Morate odabrati davaoca za brisanje");
                return;
            }
        }

        private void BtnDeleteVolunteer_Click(object sender, EventArgs e)
        {
            try
            {
                if (uCDetailsCallToAction.DgvCalledVolunteers.SelectedRows.Count == 1)
                {
                    CallToVolunteer ctv = (CallToVolunteer)uCDetailsCallToAction.DgvCalledVolunteers.SelectedRows[0].DataBoundItem;

                    Volunteer matchingVolunteer = currentVolunteers.Find(volunteer => volunteer.VolunteerID == ctv.Volunteer.VolunteerID);

                    if (matchingVolunteer != null)
                    {
                        matchingVolunteer.CrudStatus = CrudStatus.Delete;
                    }

                    calledVolunteers.Remove(ctv);
                    uCDetailsCallToAction.DgvCalledVolunteers.DataSource = null;
                    uCDetailsCallToAction.DgvCalledVolunteers.DataSource = calledVolunteers;
                }
                else
                {
                    MessageBox.Show("Morate odabrati volontera za brisanje");
                    return;
                }
            }
            catch (ServerCommunicationException ex)
            {
                MessageBox.Show(ex.ErrorMessage);
            }
        }

        private void BtnAddDonors_Click(object sender, EventArgs e)
        {
            try
            {
                List<Donor> selectedDonors = uCDetailsCallToAction.CheckedListBoxDonors.CheckedItems.Cast<Donor>().ToList();

                foreach (Donor donor in selectedDonors)
                {
                    if (!calledDonors.Any(cd => cd.Donor.JMBG == donor.JMBG) &&
                        !currentDonors.Any(cd => cd.JMBG == donor.JMBG))
                    {
                        CallToDonor callToDonor = new CallToDonor
                        {
                            JMBG = donor.JMBG,
                            ActionID = loadedAction.ActionID,
                            Donor = donor,
                            CrudStatus = CrudStatus.Create
                        };

                        calledDonors.Add(callToDonor);
                    }
                }
                uCDetailsCallToAction.DgvCalledDonors.DataSource = null;
                uCDetailsCallToAction.DgvCalledDonors.DataSource = calledDonors;
            }
            catch (ServerCommunicationException ex)
            {
                MessageBox.Show(ex.ErrorMessage);
            }
        }

        private void BtnAddVolunteers_Click(object sender, EventArgs e)
        {
            try
            {
                List<Volunteer> selectedVolunteers = uCDetailsCallToAction.CheckedListBoxVolunteers.CheckedItems.Cast<Volunteer>().ToList();

                foreach (Volunteer volunteer in selectedVolunteers)
                {
                    if (!calledVolunteers.Any(cv => cv.Volunteer.VolunteerID == volunteer.VolunteerID) &&
                        !currentVolunteers.Any(cv => cv.VolunteerID == volunteer.VolunteerID && volunteer.CrudStatus == CrudStatus.Delete))
                    {

                        CallToVolunteer callToVolunteer = new CallToVolunteer
                        {
                            VolunteerID = volunteer.VolunteerID,
                            ActionID = loadedAction.ActionID,
                            Volunteer = volunteer,
                            CrudStatus = CrudStatus.Create
                        };
                        calledVolunteers.Add(callToVolunteer);
                    }
                }

                uCDetailsCallToAction.DgvCalledVolunteers.DataSource = null;
                uCDetailsCallToAction.DgvCalledVolunteers.DataSource = calledVolunteers;
            }
            catch (ServerCommunicationException ex)
            {
                MessageBox.Show(ex.ErrorMessage);
            }
        }


        private void InitializeCommonControls()
        {
            volunteers = Communication.Instance.GetAllVolunteers();
            donors = Communication.Instance.GetAllDonors();
            listOfPlaces = Communication.Instance.GetAllPlaces();

            uCDetailsCallToAction.CmbPlaces.DataSource = listOfPlaces;
            uCDetailsCallToAction.CmbPlaces.SelectedIndex = -1;
            uCDetailsCallToAction.BtnGoBack.Click += BtnGoBack_Click;
            uCDetailsCallToAction.CmbPlaces.SelectedIndexChanged += CmbPlaces_SelectedIndexChanged;
        }

        private void CmbPlaces_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (uCDetailsCallToAction.CmbPlaces.SelectedIndex <= 0)
                {
                    uCDetailsCallToAction.CheckedListBoxVolunteers.Items.AddRange(volunteers.ToArray());
                    uCDetailsCallToAction.CheckedListBoxDonors.Items.AddRange(donors.ToArray());
                    return;
                }
                Place p = (Place)uCDetailsCallToAction.CmbPlaces.SelectedItem;

                filteredVolsByPlace = new List<Volunteer>();
                string filterConditionForVol = $" v.PLACEID = {p.PlaceID}";
                filteredVolsByPlace = Communication.Instance.FilterVolunteers(filterConditionForVol);

                filteredDonorsByPlace = new List<Donor>();
                string filterConditionForDonor = $" d.PLACEID = {p.PlaceID}";
                filteredDonorsByPlace = Communication.Instance.FilterDonors(filterConditionForDonor);

                uCDetailsCallToAction.CheckedListBoxVolunteers.Items.Clear();
                uCDetailsCallToAction.CheckedListBoxVolunteers.Items.AddRange(filteredVolsByPlace.ToArray());

                uCDetailsCallToAction.CheckedListBoxDonors.Items.Clear();
                uCDetailsCallToAction.CheckedListBoxDonors.Items.AddRange(filteredDonorsByPlace.ToArray());
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

        private void BtnCallToActionUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                loadedAction.ActionName = uCDetailsCallToAction.TxtActionName.Text;
                loadedAction.ActionTimeFromTo = uCDetailsCallToAction.TxtActionTime.Text;
                loadedAction.ActionDate = uCDetailsCallToAction.MonthCalendar1.SelectionStart;
                loadedAction.Place = (Place)uCDetailsCallToAction.CmbPlaces.SelectedItem;

                loadedAction.PlaceID = uCDetailsCallToAction.CmbPlaces.SelectedIndex;

                if (loadedAction.ActionName == null || loadedAction.ActionName == "")
                {
                    MessageBox.Show("Morate uneti ime akcije");
                    return;
                }
                else if (loadedAction.ActionTimeFromTo == null || loadedAction.ActionTimeFromTo == "")
                {
                    MessageBox.Show("Morate uneti vreme odrzavanja akcije");
                    return;
                }
                else if (loadedAction.ActionDate < DateTime.Now)
                {
                    MessageBox.Show("Akcija mora biti u buducnosti");
                    return;
                }

                List<Volunteer> volsToUpdate = new List<Volunteer>();
                volsToUpdate.AddRange(currentVolunteers);
                volsToUpdate.AddRange(calledVolunteers.Select(v => v.Volunteer).ToList());
                volsToUpdate = volsToUpdate.Distinct().ToList();

                List<Donor> donorsToUpdate = new List<Donor>();
                donorsToUpdate.AddRange(currentDonors);
                donorsToUpdate.AddRange(calledDonors.Select(d => d.Donor).ToList());
                donorsToUpdate = donorsToUpdate.Distinct().ToList();

                loadedAction.ListOfVolunteers = volsToUpdate;
                loadedAction.ListOfDonors = donorsToUpdate;

                Communication.Instance.UpdateCallToAction(loadedAction);
                MainCoordinator.Instance.ShowActionScreen(FormMode.View);
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

        private void BtnGoBack_Click(object sender, EventArgs e)
        {
            try
            {
                MainCoordinator.Instance.ShowActionScreen(FormMode.View);
            }         
            catch (ServerCommunicationException ex)
            {
                MessageBox.Show(ex.Message);
            }          
        }

        private void BtnUpdateAction_Click(object sender, EventArgs e)
        {
            try
            {
                if (uCCallToAction.DgvActions.SelectedRows.Count == 1)
                {
                    action = (BloodTransfAction)uCCallToAction.DgvActions.SelectedRows[0].DataBoundItem;
                    action.ListOfVolunteers = volunteers;
                    action.ListOfDonors = donors;

                    loadedAction = Communication.Instance.GetAction(action.ActionID);

                    MainCoordinator.Instance.ShowActionScreen(FormMode.Update);

                    uCDetailsCallToAction.TxtActionName.Text = loadedAction.ActionName;
                    uCDetailsCallToAction.TxtActionTime.Text = loadedAction.ActionTimeFromTo;
                    uCDetailsCallToAction.MonthCalendar1.SelectionStart = loadedAction.ActionDate;
                    uCDetailsCallToAction.CmbPlaces.SelectedItem = loadedAction.Place;

                    filteredVolsByPlace = new List<Volunteer>();
                    string filterConditionForVol = $" v.PLACEID = {loadedAction.Place.PlaceID}";
                    filteredVolsByPlace = Communication.Instance.FilterVolunteers(filterConditionForVol);

                    filteredDonorsByPlace = new List<Donor>();
                    string filterConditionForDonor = $" d.PLACEID = {loadedAction.Place.PlaceID}";
                    filteredDonorsByPlace = Communication.Instance.FilterDonors(filterConditionForDonor);

                    uCDetailsCallToAction.CheckedListBoxVolunteers.Items.Clear();
                    uCDetailsCallToAction.CheckedListBoxVolunteers.Items.AddRange(filteredVolsByPlace.ToArray());

                    uCDetailsCallToAction.CheckedListBoxDonors.Items.Clear();
                    uCDetailsCallToAction.CheckedListBoxDonors.Items.AddRange(filteredDonorsByPlace.ToArray());

                    calledVolunteers = Communication.Instance.FindVolunteerCalls(loadedAction);
                    uCDetailsCallToAction.DgvCalledVolunteers.DataSource = calledVolunteers;
                    currentVolunteers = calledVolunteers.Select(vc => vc.Volunteer).ToList();
                    currentVolunteers.ForEach(volunteer => volunteer.CrudStatus = CrudStatus.Update);


                    calledDonors = Communication.Instance.FindDonorCalls(loadedAction);
                    uCDetailsCallToAction.DgvCalledDonors.DataSource = calledDonors;
                    currentDonors = calledDonors.Select(dc => dc.Donor).ToList();
                    currentDonors.ForEach(donor => donor.CrudStatus = CrudStatus.Update);
                }
                else
                {
                    MessageBox.Show("Morate izabrati jednu akciju da biste je azurirali");
                    return;
                }
            }
            catch (ServerCommunicationException ex)
            {
                MessageBox.Show(ex.ErrorMessage);
            }
        }

        private void BtnCreateAction_Click(object sender, EventArgs e)
        {
            try
            {
                MainCoordinator.Instance.ShowActionScreen(FormMode.Add);
            }
            catch (ServerCommunicationException ex)
            {
                MessageBox.Show(ex.ErrorMessage);
            }
        }

        private void BtnCallToActionAdd_Click(object sender, EventArgs e)
        {
            bool successful = true;
            bool serverException = false;
            try
            {
                List<Volunteer> volunteers = uCDetailsCallToAction.CheckedListBoxVolunteers.CheckedItems.Cast<Volunteer>().ToList();
                List<Donor> donors = uCDetailsCallToAction.CheckedListBoxDonors.CheckedItems.Cast<Donor>().ToList();

                string actionName = uCDetailsCallToAction.TxtActionName.Text;
                string actionTime = uCDetailsCallToAction.TxtActionTime.Text;
                Place actionPlace = (Place)uCDetailsCallToAction.CmbPlaces.SelectedItem;
                DateTime actionDate = uCDetailsCallToAction.MonthCalendar1.SelectionStart;

                if (actionName == null || actionName == "")
                {
                    MessageBox.Show("Morate uneti ime akcije");
                    successful = false;
                    return;
                }
                else if (actionTime == null || actionTime == "")
                {
                    MessageBox.Show("Morate uneti vreme odrzavanja akcije");
                    successful = false;
                    return;
                }
                else if (actionDate < DateTime.Now) {
                    MessageBox.Show("Akcija mora biti u buducnosti");
                    successful = false;
                    return;
                }

                action = new BloodTransfAction()
                {
                    ActionName = actionName,
                    ActionDate = actionDate,
                    ActionTimeFromTo = actionTime,
                    Place = actionPlace,
                    PlaceID = actionPlace.PlaceID,
                    ListOfVolunteers = volunteers,
                    ListOfDonors = donors,
                    CrudStatus = CrudStatus.Create
                };

                Communication.Instance.CallToAction(action);

                actionsForDgv.Add(action);
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
                serverException = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                successful = false;
            }
            finally
            {
                if (!serverException)
                {
                    DialogResult finallyResult = MessageBox.Show("Da li želite nastavite da dodajete akcije?", "Nastavi dodavanje", MessageBoxButtons.YesNo);

                    if (finallyResult == DialogResult.No)
                    {
                        MainCoordinator.Instance.ShowActionScreen(FormMode.View);
                    }

                    else
                    {
                        if (successful)
                        {
                            uCDetailsCallToAction.TxtActionName.Text = "";
                            uCDetailsCallToAction.TxtActionTime.Text = "";
                            uCDetailsCallToAction.CmbPlaces.SelectedIndex = -1;
                            uCDetailsCallToAction.MonthCalendar1.SelectionStart = DateTime.Now;
                        }

                    }
                }
            }
        }
    }

}
