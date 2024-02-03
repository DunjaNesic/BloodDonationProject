using BloodDonation.Common.Domain;
using BloodDonation.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.SystemOperations
{
    public class LoadActionSO : SystemOperationBase
    {
        protected override void ExecuteConcreteOperation(IEntity entity)
        {
            try
            {
                BloodTransfAction a = (BloodTransfAction)entity;
                Result = genericRepository.Get(a, a.FilterQuery);
            }
            catch (Exception)
            {
                throw new Exception("Sistem ne može da učita volontera");
            }
        }
    }
}
