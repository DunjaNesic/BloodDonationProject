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
    public class CallToVolunteer : IEntity
    {
        [Browsable(false)]
        public int VolunteerID { get; set; }

        [Browsable(false)]
        public int ActionID { get; set; }
        public Volunteer Volunteer { get; set; }

        [Browsable(false)]
        public string TableName => "CallToVolunteer";

        [Browsable(false)]
        public string TableAlias => "ctv";

        [Browsable(false)]
        public string InsertValues => $"{VolunteerID}, {ActionID}";

        [Browsable(false)]
        public string SelectValues => "*";

        [Browsable(false)]
        public string JoinTable => "JOIN VOLUNTEER V";

        [Browsable(false)]
        public string JoinCondition => "ON (V.VOLUNTEERID = CTV.VOLUNTEERID)";

        [Browsable(false)]
        public string UpdateValues => "";

        [Browsable(false)]
        public string IDName => "VolunteerID";

        [Browsable(false)]
        public string FilterQuery { get; set; }

        [Browsable(false)]
        public CrudStatus CrudStatus { get; set; }
        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> callsToVolunteer = new List<IEntity>();
            while (reader.Read())
            {
                callsToVolunteer.Add(new CallToVolunteer()
                {
                    VolunteerID = reader.GetInt32(0),
                    ActionID = reader.GetInt32(1),
                    Volunteer = new Volunteer() {
                    VolunteerID = reader.GetInt32(2),
                    VolunteerName = reader.GetString(3),
                    VolunteerLastName = reader.GetString(4),
                    DateFreeFrom = reader.GetDateTime(5),
                    DateFreeTo = reader.GetDateTime(6),
                    PlaceID = reader.GetInt32(7),
                    }
                });
            }
            return callsToVolunteer;
        }

        public override string ToString()
        {
            return Volunteer.VolunteerName + " " + Volunteer.VolunteerLastName; 
        }
    }
}
