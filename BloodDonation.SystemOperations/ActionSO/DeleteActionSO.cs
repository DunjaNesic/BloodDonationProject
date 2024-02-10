using BloodDonation.Common.Domain;
using BloodDonation.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.SystemOperations.ActionSO
{
    public class DeleteActionSO : SystemOperationBase
    {
        protected override void ExecuteConcreteOperation(IEntity entity)
        {
            try
            {
                BloodTransfAction action = (BloodTransfAction)entity;
                genericRepository.Delete(action, action.DeleteQuery);
            }
            catch (Exception)
            {
                throw new Exception("Sistem ne može da obriše akciju");
            }
        }
    }
}
