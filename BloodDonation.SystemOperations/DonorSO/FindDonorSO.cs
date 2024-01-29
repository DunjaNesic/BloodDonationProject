using BloodDonation.Common.Domain;
using BloodDonation.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.SystemOperations
{
    public class FindDonorSO : SystemOperationBase
    {
        protected override void ExecuteConcreteOperation(IEntity entity)
        {
            try
            {
                Donor d = (Donor)entity;
                Result = genericRepository.Get(d, d.FilterQuery);
            }
            catch (Exception)
            {
                throw new Exception("Sistem ne može da pronađe davaoca po zadatoj vrednosti");
            }
        }
    }
}
