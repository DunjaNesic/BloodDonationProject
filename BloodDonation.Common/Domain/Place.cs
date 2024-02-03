using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BloodDonation.Repository.Interfaces;


namespace BloodDonation.Common.Domain
{
    [Serializable]
    public class Place : IEntity
    {
        public int PlaceID { get; set; }
        public string PlaceName { get; set; }
        public Place Self { get{ return this; } }
        public string TableName => "Place";

        public string TableAlias => "p";

        public string InsertValues => $"{PlaceID}, '{PlaceName}'";

        public string SelectValues => "*";

        public string JoinTable => "";

        public string JoinCondition => "";

        public string UpdateValues => throw new NotImplementedException();

        public string IDName => "PlaceID";

        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> entityList = new List<IEntity>();
            while (reader.Read())
            {
                entityList.Add(new Place() { 
                PlaceID = (int)reader["PlaceID"],
                PlaceName = (string)reader["PlaceName"]
                });
            }
            return entityList;
        }

        public override string ToString()
        {
            return this.PlaceName; 
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Place otherPlace = (Place)obj;

            return PlaceID == otherPlace.PlaceID;
        }

        public override int GetHashCode()
        {
            return PlaceID.GetHashCode();
        }
    }
}
