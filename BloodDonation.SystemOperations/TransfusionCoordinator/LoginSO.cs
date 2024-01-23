using BloodDonation.Common.Domain;
using BloodDonation.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.SystemOperations
{
    public class LoginSO : SystemOperationBase
    {
        protected override void ExecuteConcreteOperation(IEntity entity)
        {
            TransfusionCenterCoordinator c = (TransfusionCenterCoordinator)entity;
            Result = genericRepository.Get(c, $" COORDINATORCODE = '{c.CoordinatorCode}' AND PASSWORD = '{c.Password}'");
            //if (Result == null) throw new Exception("U centru za transfuziju ne postoji koordinator sa ovim kredencijalima");          
        }
    }
}
