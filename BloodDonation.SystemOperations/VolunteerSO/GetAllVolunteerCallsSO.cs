using BloodDonation.Common.Domain;
using BloodDonation.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.SystemOperations.VolunteerSO
{
    public class GetAllVolunteerCallsSO : SystemOperationBase
    {
        protected override void ExecuteConcreteOperation(IEntity entity)
        {
            try
            {
                BloodTransfAction action = (BloodTransfAction)entity;
                CallToVolunteer ctv = new CallToVolunteer();
                ctv.FilterQuery = $" (ctv.ActionID = {action.ActionID})";
                Result = genericRepository.Find(ctv, ctv.FilterQuery).Cast<CallToVolunteer>().ToList();
            }
            catch (Exception)
            {
                throw new Exception("Sistem ne može da učita pozvane volontere na akciju");
            }
        }
    }
}
