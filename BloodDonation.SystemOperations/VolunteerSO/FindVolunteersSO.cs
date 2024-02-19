using BloodDonation.Common.Domain;
using BloodDonation.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.SystemOperations
{
    public class FindVolunteersSO : SystemOperationBase
    {
        protected override void ExecuteConcreteOperation(IEntity entity)
        {
            try
            {
                Volunteer v = (Volunteer)entity;
                Result = genericRepository.Find(v, v.FilterQuery).Cast<Volunteer>().ToList();
            }
            catch (Exception)
            {
                throw new Exception("Sistem ne može da pronađe volontere po zadatoj vrednosti");
            }
        }
    }
}
