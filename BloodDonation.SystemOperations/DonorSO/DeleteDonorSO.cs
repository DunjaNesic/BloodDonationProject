﻿using BloodDonation.Common.Domain;
using BloodDonation.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.SystemOperations
{
    public class DeleteDonorSO : SystemOperationBase
    {
        protected override void ExecuteConcreteOperation(IEntity entity)
        {
            try
            {
                Donor donor = (Donor)entity;
                genericRepository.Delete(donor, donor.DeleteQuery);
                Result = true;
            }
            catch (SqlException ex) {
                Debug.WriteLine(">>>>>" + ex.Message);
                Result = false;
            }
            catch (Exception ex)
            {
                Result = false;
                Debug.WriteLine(">>>" + ex.Message);
            }
        }
    }
}
