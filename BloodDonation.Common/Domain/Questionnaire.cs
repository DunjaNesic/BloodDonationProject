using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.Common.Domain
{
    [Serializable]
    public class Questionnaire
    {
        public int QuestionnaireID { get; set; }
        public string JMBG { get; set; }
        public int ActionID { get; set; }
        public string DonorAnswers { get; set; }
        public string MedicalWorkerAnswers { get; set; }
        public DateTime QuestionnaireDate { get; set; }
        public string Remark { get; set; }        
        public enum QuestionnaireConsent { 
            Negative = 0,
            Positive = 1       
        }
    }
}
