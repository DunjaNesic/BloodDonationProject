using BloodDonation.Common.Domain;
using BloodDonation.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.SystemOperations.TransfusionCoordinator
{
    public class GetAllQuestionnairesSO : SystemOperationBase
    {
        protected override void ExecuteConcreteOperation(IEntity entity)
        {
            try
            {
                Questionnaire questionnaire = (Questionnaire)entity;
                Result = genericRepository.Find(questionnaire, questionnaire.FilterQuery).Cast<Questionnaire>().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
