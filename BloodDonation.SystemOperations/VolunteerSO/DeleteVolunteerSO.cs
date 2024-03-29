﻿using BloodDonation.Common.Domain;
using BloodDonation.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.SystemOperations
{
    public class DeleteVolunteerSO : SystemOperationBase
    {
        protected override void ExecuteConcreteOperation(IEntity entity)
        {
            try
            {
                Volunteer volunteer = (Volunteer)entity;
                genericRepository.Delete(volunteer, volunteer.DeleteQuery);               
            }
            catch (Exception)
            {             
                throw new Exception("Sistem ne može da obriše volontera");
            }
        }
    }
}
