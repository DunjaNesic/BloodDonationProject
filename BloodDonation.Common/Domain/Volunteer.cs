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
    public class Volunteer : IEntity
    {
        public int VolunteerID { get; set; }
        public string VolunteerName { get; set; }
        public string VolunteerLastName { get; set; }
        public DateTime DateFreeFrom { get; set; }
        public DateTime DateFreeTo { get; set; }
        //public int PlaceID { get; set; } mozda je bolje s ovim nisam sig videcu posle
        public Place Place { get; set; }

        public string TableName => "Volunteer";

        public string TableAlias => "v";

        public string InsertValues => $"{VolunteerID}, '{VolunteerName}', '{VolunteerLastName}', {DateFreeFrom.ToString("yyyy-MM-dd HH:mm:ss")}, {DateFreeTo.ToString("yyyy-MM-dd HH:mm:ss")}, {Place.PlaceID}";

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
