using BloodDonation.Common.Domain;
using BloodDonation.Repository.Interfaces;
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
                genericRepository.Add(volunteer);
                Result = volunteer;
            }
            catch (Exception)
            {
                throw new Exception("Sistem ne može da kreira volontera");
            }

        }
    }
}
