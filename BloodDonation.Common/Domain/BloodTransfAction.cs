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
        public List<Volunteer> ListOfVolunteers { get; set; }
        public List<Donor> ListOfDonors { get; set; }

        [Browsable(false)]
        public int PlaceID { get; set; }

        [Browsable(false)]
        public string TableName => "Action";

        [Browsable(false)]
        public string TableAlias => "a";

        [Browsable(false)]
        public string InsertValues => $"'{ActionName}', '{ActionDate:yyyy - MM - dd HH:mm:ss}', '{ActionTimeFromTo}', {PlaceID}";

        [Browsable(false)]
        public string SelectValues => "*";

        [Browsable(false)]
        public string JoinTable => "JOIN PLACE p";

        [Browsable(false)]
        public string JoinCondition => "ON (p.PlaceID = a.PlaceID)";

        [Browsable(false)]
        public string FilterQuery { get; set; }

        [Browsable(false)]
        public string UpdateValues => $" ActionName = '{ActionName}', ActionDate = '{ActionDate:yyyy-MM-dd HH:mm:ss}', ActionTimeFromTo = '{ActionTimeFromTo}', PlaceID = {Place.PlaceID}";

        [Browsable(false)]
        public string IDName => "ActionID";

        [Browsable(false)]
        public CrudStatus CrudStatus { get; set; }
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
