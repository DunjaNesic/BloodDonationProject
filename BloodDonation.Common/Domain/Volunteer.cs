using BloodDonation.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.Common.Domain
{
    [Serializable]
    public class Volunteer : IEntity
    {
        [Browsable(false)]
        public int VolunteerID { get; set; }
        public string VolunteerName { get; set; }
        public string VolunteerLastName { get; set; }
        public DateTime DateFreeFrom { get; set; }
        public DateTime DateFreeTo { get; set; }

        [Browsable(false)]
        public string FilterQuery { get; set; }

        [Browsable(false)]
        public string DeleteQuery => $"VolunteerID = {VolunteerID}";

        [Browsable(false)]
        public int PlaceID { get; set; }
        
        public Place Place { get; set; }

        [Browsable(false)]
        public string TableName => "Volunteer";
        [Browsable(false)]
        public string TableAlias => "v";
        [Browsable(false)]
        public string InsertValues => $"'{VolunteerName}', '{VolunteerLastName}', '{DateFreeFrom:yyyy-MM-dd HH:mm:ss}', '{DateFreeTo:yyyy-MM-dd HH:mm:ss}', {PlaceID}";
        [Browsable(false)]
        public string SelectValues => "*";
        [Browsable(false)]
        public string JoinTable => "JOIN PLACE p";
        [Browsable(false)]
        public string JoinCondition => "ON(v.PlaceID = p.PlaceID)";
        [Browsable(false)]
        public string UpdateValues => "";
        [Browsable(false)]
        public string IDName => "VolunteerID";
        public override string ToString()
        {
            return this.VolunteerName + " " + this.VolunteerLastName;
        }
        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> volunteers = new List<IEntity>();
            while (reader.Read()) {
                volunteers.Add(new Volunteer() { 
                    VolunteerID = reader.GetInt32(0),
                    VolunteerName = reader.GetString(1),
                    VolunteerLastName = reader.GetString(2),    
                    DateFreeFrom = reader.GetDateTime(3),
                    DateFreeTo = reader.GetDateTime(4),
                    Place = new Place() { 
                    PlaceID = reader.GetInt32(5),
                    PlaceName = reader.GetString(7)
                    }
                });
            }
            return volunteers;
        }
    }
}
