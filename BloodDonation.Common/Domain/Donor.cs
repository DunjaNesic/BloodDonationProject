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
    public enum BloodType
    {
        APozitivna,
        ANegativna,
        BPozitivna,
        BNegativna,
        ABPozitivna,
        ABNegativna,
        OPozitivna,
        ONegativna
    }
    public enum IsActive
    {
        Ne = 0,
        Da = 1
    }

    [Serializable]
    public class Donor : IEntity
    {
        public string JMBG { get; set; }
        public string DonorName { get; set; }
        public string DonorLastName { get; set; }
        public string DonorContact { get; set; }
        public BloodType BloodType { get; set; }

        [Browsable(false)]
        public IsActive IsActive { get; set; }
        public Place Place { get; set; }
        public DateTime LastDonationDate { get; set; }

        [Browsable(false)]
        public string FilterQuery { get; set; }

        [Browsable(false)]
        public string DeleteQuery => $"JMBG = '{JMBG}'";

        [Browsable(false)]
        public int PlaceID { get; set; }

        [Browsable(false)]
        public string TableName => "Donor";

        [Browsable(false)]
        public string TableAlias => "d";

        [Browsable(false)]
        public string InsertValues => $"'{JMBG}', '{DonorName}', '{DonorLastName}', {(int)BloodType}, '{DonorContact}', '{LastDonationDate:yyyy-MM-dd HH:mm:ss}', {(int)IsActive}, {PlaceID}";

        [Browsable(false)]
        public string SelectValues => "*";

        [Browsable(false)]
        public string JoinTable => "JOIN Place p";

        [Browsable(false)]
        public string JoinCondition => "ON(d.PlaceID = p.PlaceID)";

        [Browsable(false)]
        public string UpdateValues => $"DonorName = '{DonorName}', DonorLastName = '{DonorLastName}', DonorContact = '{DonorContact}', LastDonationDate = '{LastDonationDate: yyyy-MM-dd HH:mm:ss}', IsActive = {(int)IsActive}";

        [Browsable(false)]
        public string IDName => "JMBG";
        public override string ToString()
        {
            return this.DonorName + " " + this.DonorLastName;
        }
        public List<IEntity> GetReaderList(SqlDataReader reader) { 
        List<IEntity> donors = new List<IEntity>();

            while (reader.Read()) {
                donors.Add(new Donor() { 
                    JMBG = reader["JMBG"].ToString(),
                    DonorName = reader["DonorName"].ToString(),
                    DonorLastName = reader["DonorLastName"].ToString(),
                    BloodType = (BloodType)Enum.Parse(typeof(BloodType), reader["BloodType"].ToString()),
                    DonorContact = reader["DonorContact"].ToString(),
                    LastDonationDate = Convert.ToDateTime(reader["LastDonationDate"]),
                    IsActive = (IsActive)Enum.Parse(typeof(IsActive), reader["IsActive"].ToString()),
                    Place = new Place() {
                        PlaceID = Convert.ToInt32(reader["PlaceID"]),
                        PlaceName = reader["PlaceName"].ToString()
                    }
                });
            }
            return donors;
        }


    }
}   

