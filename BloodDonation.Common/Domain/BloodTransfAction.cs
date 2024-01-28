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
    public class BloodTransfAction : IEntity
    {

        [Browsable(false)]
        public int ActionID { get; set; }
        public string ActionName { get; set; }
        public DateTime ActionDate { get; set; }
        public string ActionTimeFromTo { get; set; }
        public Place Place { get; set; }

        [Browsable(false)]
        public int PlaceID { get; set; }
        public string TableName => "Action";

        [Browsable(false)]
        public string TableAlias => "a";

        [Browsable(false)]
        public string InsertValues => "";

        [Browsable(false)]
        public string SelectValues => "*";

        [Browsable(false)]
        public string JoinTable => "JOIN PLACE p";

        [Browsable(false)]
        public string JoinCondition => "ON (p.PlaceID = a.PlaceID)";

        //public string JoinCondition => $"JOIN CALLTODONOR ctd ON (ctd.ActionID = a.ActionID) JOIN CALLTOVOLUNTEER ctv ON (ctv.ActionID = a.ActionID) JOIN PLACE p ON (a.PlaceID = p.PlaceID)";

        [Browsable(false)]
        public string UpdateValues => "";

        [Browsable(false)]
        public string IDName => "ActionID";
        public override string ToString()
        {
            return this.ActionName; 
        }
        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
           List<IEntity> actions = new List<IEntity>();

            while (reader.Read()) {
                actions.Add(new BloodTransfAction() { 
                    ActionID = reader.GetInt32(0),
                    ActionName = reader.GetString(1),
                    ActionDate = reader.GetDateTime(2),
                    ActionTimeFromTo = reader.GetString(3),
                    Place = new Place() { 
                    PlaceID = reader.GetInt32(4),
                    PlaceName = reader.GetString(6),
                    } 
                });
            }
            return actions;
        }
    }
}
