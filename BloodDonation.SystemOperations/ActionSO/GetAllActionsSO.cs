using BloodDonation.Common.Domain;
using BloodDonation.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.SystemOperations
{
    public class GetAllActionsSO : SystemOperationBase
    {
        protected override void ExecuteConcreteOperation(IEntity entity)
        {
            BloodTransfAction action = (BloodTransfAction)entity;
            Result = genericRepository.GetAll(action).Cast<BloodTransfAction>().ToList();
        }
    }
}
