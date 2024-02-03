using BloodDonation.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.Common.Domain
{
    public enum QuestionnaireConsent
    {
        Negative = 0,
        Positive = 1
    }

    [Serializable]
    public class Questionnaire : IEntity
    {
        [Browsable(false)]
        public int QuestionnaireID { get; set; }

        [Browsable(false)]
        public string JMBG { get; set; }

        [Browsable(false)]
        public int ActionID { get; set; }
        public string DonorAnswers { get; set; }
        public string MedicalWorkerAnswers { get; set; }
        public DateTime QuestionnaireDate { get; set; }
        public string Remark { get; set; }
        public QuestionnaireConsent QuestionnaireConsent { get; set; }

        [Browsable(false)]
        public string FilterQuery { get; set; }

        [Browsable(false)]
        public string TableName => "Questionnaire";

        [Browsable(false)]
        public string IDName => "QuestionnaireID";

        [Browsable(false)]
        public string TableAlias => "q";

        [Browsable(false)]
        public string InsertValues => "";

        [Browsable(false)]
        public string SelectValues => "*";

        [Browsable(false)]
        public string UpdateValues => "";

        [Browsable(false)]
        public string JoinTable => "";

        [Browsable(false)]
        public string JoinCondition => "";


        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> quests = new List<IEntity>();
            while (reader.Read()) {
                quests.Add(new Questionnaire() { 
                QuestionnaireID = reader.GetInt32(0),
                JMBG = reader.GetString(1),
                ActionID = reader.GetInt32(2),
                DonorAnswers = reader.GetString(3),
                MedicalWorkerAnswers = reader.GetString(4),
                QuestionnaireDate = reader.GetDateTime(5),
                Remark = reader.GetString(6),
                QuestionnaireConsent = (QuestionnaireConsent)reader.GetInt32(7)
                });
            
            }
            return quests;
        }


    }
}
