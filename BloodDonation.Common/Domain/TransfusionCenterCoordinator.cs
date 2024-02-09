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
    public class TransfusionCenterCoordinator : IEntity
    {
        public int CoordinatorID { get; set; }
        public string CoordinatorName { get; set; }
        public string CoordinatorLastName { get; set; }
        public string CoordinatorCode { get; set; }
        public string Password { get; set; }

        public string TableName => "TransfusionCenterCoordinator";

        public string TableAlias => "";

        public string InsertValues => "";

        public string SelectValues => "*";

        public string JoinTable => "";

        public string JoinCondition => "";

        public string UpdateValues => "";

        public string IDName => "CoordinatorCode";

        public override bool Equals(object obj)
        {
            return obj is TransfusionCenterCoordinator coordinator &&
                   CoordinatorCode == coordinator.CoordinatorCode &&
                   Password == coordinator.Password;
        }
        public override int GetHashCode()
        {
            int hashCode = 1736740912;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CoordinatorCode);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Password);
            return hashCode;
        }
        public List<IEntity> GetReaderList(SqlDataReader reader)
        {
            List<IEntity> entityList = new List<IEntity>();
            while (reader.Read()) {
                entityList.Add(new TransfusionCenterCoordinator() { 
                    CoordinatorID = (int)reader["CoordinatorID"],
                    CoordinatorName = (string)reader["CoordinatorName"],
                    CoordinatorLastName = (string)reader["CoordinatorLastName"],
                    CoordinatorCode = (string)reader["CoordinatorCode"],
                    Password = (string)reader["Password"]
                });
            }
            return entityList;
        }
    }
}
