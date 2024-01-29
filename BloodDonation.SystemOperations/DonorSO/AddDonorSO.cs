using BloodDonation.Common.Domain;
using BloodDonation.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.SystemOperations
{
    public class AddDonorSO : SystemOperationBase
    {
        protected override void ExecuteConcreteOperation(IEntity entity)
        {
            try
            {
                Donor donor = (Donor)entity;
                genericRepository.Add(donor);
                Result = donor;
            }
            catch (Exception)
            {
                throw new Exception("Sistem ne može da kreira davaoca");
            }
        }
    }
}
