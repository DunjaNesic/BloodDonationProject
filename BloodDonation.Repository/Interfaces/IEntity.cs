using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.Repository.Interfaces
{
    public interface IEntity
    {
        string TableName { get; }
        string IDName { get; }
        string TableAlias { get; }
        string InsertValues { get; }
        string SelectValues { get; }
        string UpdateValues { get; }
        string JoinTable { get; }
        string JoinCondition { get; }
        List<IEntity> GetReaderList(SqlDataReader reader);
    }
}
