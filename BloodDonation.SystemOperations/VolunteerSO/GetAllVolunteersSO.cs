using BloodDonation.Common.Domain;
using BloodDonation.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.SystemOperations
{
    public class GetAllVolunteersSO : SystemOperationBase
    {
        protected override void ExecuteConcreteOperation(IEntity entity)
        {
            Volunteer v = (Volunteer)entity;
            Result = genericRepository.GetAll(v).Cast<Volunteer>().ToList();
        }
    }
}
