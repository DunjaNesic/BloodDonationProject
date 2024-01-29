using BloodDonation.Common.Domain;
using BloodDonation.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.SystemOperations.VolunteerSO
{
    public class LoadVolunteerSO : SystemOperationBase
    {
        protected override void ExecuteConcreteOperation(IEntity entity)
        {
            try
            {
                Volunteer v = (Volunteer)entity;
                Result = genericRepository.Get(v, v.FilterQuery);
            }
            catch (Exception)
            {
                throw new Exception("Sistem ne može da učita volontera");
            }
        }
    }
}
