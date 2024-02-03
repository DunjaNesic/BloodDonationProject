using BloodDonation.Common.Domain;
using BloodDonation.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.SystemOperations.DonorSO
{
    public class GetAllDonorCallsSO : SystemOperationBase
    {
        protected override void ExecuteConcreteOperation(IEntity entity)
        {
            try
            {
                BloodTransfAction action = (BloodTransfAction)entity;
                CallToDonor ctd = new CallToDonor();
                ctd.FilterQuery = $" (ctd.ActionID = {action.ActionID})";
                Result = genericRepository.Find(ctd, ctd.FilterQuery).Cast<CallToDonor>().ToList();
            }
            catch (Exception)
            {
                throw new Exception("Sistem ne može da učita pozvane davaoce na akciju");
            }
        }
    }
}
