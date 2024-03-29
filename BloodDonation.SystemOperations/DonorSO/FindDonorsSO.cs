﻿using BloodDonation.Common.Domain;
using BloodDonation.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.SystemOperations.DonorSO
{
    public class FindDonorsSO : SystemOperationBase
    {
        protected override void ExecuteConcreteOperation(IEntity entity)
        {
            Donor d = (Donor)entity;
            Result = genericRepository.Find(d, d.FilterQuery).Cast<Donor>().ToList();
        }
    }
}
