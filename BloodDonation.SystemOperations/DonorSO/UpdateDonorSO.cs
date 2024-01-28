using BloodDonation.Common.Domain;
using BloodDonation.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.SystemOperations.DonorSO
{
    public class UpdateDonorSO : SystemOperationBase
    {
        protected override void ExecuteConcreteOperation(IEntity entity)
        {
            try
            {
                Donor d = (Donor)entity;
                genericRepository.Update(d, $"JMBG='{d.JMBG}'");
                Result = true;
            }
            catch (Exception ex)
            {
                Result = false;
                Debug.WriteLine(">>>" + ex.Message);
            }
        }
    }
}
