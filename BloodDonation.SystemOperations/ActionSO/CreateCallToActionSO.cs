using BloodDonation.Common.Domain;
using BloodDonation.Repository.Interfaces;
using BloodDonation.SystemOperations.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.SystemOperations
{
    public class CreateCallToActionSO : SystemOperationBase
    {
        protected override void ExecuteConcreteOperation(IEntity entity)
        {
            try
            {
                BloodTransfAction action = (BloodTransfAction)entity;
               
                    action.ValidateAction();
                    genericRepository.Add(action);               

                List<Volunteer> volunteers = action.ListOfVolunteers;
                List<Donor> donors = action.ListOfDonors;

                CallToDonor ctd;
                CallToVolunteer ctv;

                foreach (Volunteer v in volunteers)
                {
                    v.ValidateVolunteer(action);
                    ctv = new CallToVolunteer()
                    {
                        ActionID = action.ActionID,
                        VolunteerID = v.VolunteerID,
                    };
                    genericRepository.Add(ctv);
                }
                foreach (Donor d in donors)
                {
                    d.ValidateDonor(action);
                    ctd = new CallToDonor()
                    {
                        ActionID = action.ActionID,
                        JMBG = d.JMBG,
                    };
                    genericRepository.Add(ctd);
                }
            }
            catch (VolunteerException ex)
            {
                throw new Exception(ex.ErrorMessage);
            }
            catch (DonorException ex)
            {
                throw new Exception(ex.ErrorMessage);
            }
            catch (ActionException ex)
            {
                throw new Exception(ex.ErrorMessage);
            }
            catch (Exception)
            {
                throw new Exception("Sistem ne može da kreira poziv na akciju");
            }
        }
    }
}
