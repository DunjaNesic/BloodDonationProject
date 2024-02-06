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
    public class AddVolunteerSO : SystemOperationBase
    {
        protected override void ExecuteConcreteOperation(IEntity entity)
        {
            try
            {
                Volunteer volunteer = (Volunteer)entity;
                volunteer.ValidateVolunteer();
                genericRepository.Add(volunteer);
                Result = volunteer;
            }
            catch (VolunteerException ex) {
                throw new Exception(ex.ErrorMessage);
            }
            catch (Exception)
            {
                throw new Exception("Sistem ne može da kreira volontera");
            }

        }
    }
}
