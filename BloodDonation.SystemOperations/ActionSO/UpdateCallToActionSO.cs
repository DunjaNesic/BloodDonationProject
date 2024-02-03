using BloodDonation.Common.Domain;
using BloodDonation.Repository.Interfaces;
using System;
using System.Collections.Generic;

namespace BloodDonation.SystemOperations
{
    public class UpdateCallToActionSO : SystemOperationBase
    {
        protected override void ExecuteConcreteOperation(IEntity entity)
        {
            try
            {
                BloodTransfAction action = (BloodTransfAction)entity;

                genericRepository.Update(action, $"ActionID = {action.ActionID}");


                foreach (Volunteer volunteer in action.ListOfVolunteers)
                {
                    CallToVolunteer ctv = new CallToVolunteer()
                    {
                        ActionID = action.ActionID,
                        VolunteerID = volunteer.VolunteerID
                    };

                    if (volunteer.CrudStatus == CrudStatus.Create)
                    {
                        genericRepository.Add(ctv);

                    }
                    else if (volunteer.CrudStatus == CrudStatus.Delete)
                    {

                        genericRepository.Delete(ctv, $"ActionID = {ctv.ActionID} AND VolunteerID = {ctv.VolunteerID}");
                    }                   
                }
                foreach (Donor donor in action.ListOfDonors)
                {
                    CallToDonor ctd = new CallToDonor()
                    {
                        ActionID = action.ActionID,
                        JMBG = donor.JMBG,
                    };

                    if (donor.CrudStatus == CrudStatus.Create)
                    {
                        genericRepository.Add(ctd);

                    }
                    else if (donor.CrudStatus == CrudStatus.Delete)
                    {
                        genericRepository.Delete(ctd, $"ActionID = {ctd.ActionID} AND JMBG = '{ctd.JMBG}'");
                    } 
                }
            }
            catch (Exception)
            {
                throw new Exception("Sistem ne može da ažurira poziv na akciju");
            }
        }
    }
}
