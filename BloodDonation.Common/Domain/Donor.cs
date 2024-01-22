using BloodDonation.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.Common.Domain
{
    [Serializable]
    public class Donor : IEntity
    {
        public string JMBG { get; set; }
        public string DonorName { get; set; }
        public string DonorLastName { get; set; }
        public enum BloodType {
            APositive,
            ANegative,
            BPositive,
            BNegative,
            ABPositive,
            ABNegative,
            OPositive,
            ONegative
        }
        public string DonorContact { get; set; }
        public DateTime LastDonationDate { get; set; }
        public enum IsActive { 
            No = 0,
            Yes = 1
        }
        public int PlaceID { get; set; }

        public string TableName => throw new NotImplementedException();

        public string TableAlias => throw new NotImplementedException();

        public string InsertValues => throw new NotImplementedException();

        public string SelectValues => throw new NotImplementedException();

        public string JoinTable => throw new NotImplementedException();

        public string JoinCondition => throw new NotImplementedException();

        public string UpdateValues => throw new NotImplementedException();

        public string IDName => throw new NotImplementedException();

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
