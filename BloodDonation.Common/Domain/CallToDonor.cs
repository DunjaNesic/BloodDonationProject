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
    [Serializable]
    public class CallToDonor : IEntity
    {
        [Browsable(false)]
        public string JMBG { get; set; }

        [Browsable(false)]
        public int ActionID { get; set; }
        public Donor Donor { get; set; }

        [Browsable(false)]
        public string TableName => "CallToDonor";

        [Browsable(false)]
        public string TableAlias => "ctd";

        [Browsable(false)]
        public string InsertValues => $" '{JMBG}', {ActionID}";

        [Browsable(false)]
        public string SelectValues => "*";

        [Browsable(false)]
        public string JoinTable => "JOIN DONOR D";

        [Browsable(false)]
        public string JoinCondition => "ON (D.JMBG = CTD.JMBG)";

        [Browsable(false)]
        public string UpdateValues => "";

        [Browsable(false)]
        public string IDName => "ActionID";

        [Browsable(false)]
        public string FilterQuery { get; set; }

        [Browsable(false)]
        public CrudStatus CrudStatus { get; set; }
        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> callsToDonor = new List<IEntity>();
            while (reader.Read()) {
                callsToDonor.Add(new CallToDonor() { 
                JMBG = reader.GetString(0),
                ActionID = reader.GetInt32(1),
                    Donor = new Donor()
                    {
                       JMBG = reader.GetString(2),
                       DonorName = reader.GetString(3),
                       DonorLastName = reader.GetString(4),
                       BloodType = (BloodType)Enum.Parse(typeof(BloodType), reader["BloodType"].ToString()),
                       DonorContact = reader.GetString(6),
                       LastDonationDate = reader.GetDateTime(7),
                       IsActive = (IsActive)Enum.Parse(typeof(IsActive), reader["IsActive"].ToString()),
                       PlaceID = reader.GetInt32(9)
                    }
                });
            }
            return callsToDonor;
        }
        public override string ToString()
        {
            return Donor.DonorName + " " + Donor.DonorLastName;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            CallToDonor other = (CallToDonor)obj;

            return JMBG == other.JMBG && ActionID == other.ActionID;
        }

        public override int GetHashCode()
        {
            int hashCode = -963372243;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(JMBG);
            hashCode = hashCode * -1521134295 + ActionID.GetHashCode();
            return hashCode;
        }
    }
}
