using BloodDonation.Common.Domain;
using BloodDonation.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.SystemOperations.ActionSO
{
    public class FindActionsSO : SystemOperationBase
    {
        protected override void ExecuteConcreteOperation(IEntity entity)
        {
            try
            {
                BloodTransfAction a = (BloodTransfAction)entity;
                Result = genericRepository.Find(a, a.FilterQuery).Cast<BloodTransfAction>().ToList();
            }
            catch (Exception)
            {
                throw new Exception("Sistem ne može da pronađe akcije po zadatoj vrednosti");
            }
        }
    }
}
