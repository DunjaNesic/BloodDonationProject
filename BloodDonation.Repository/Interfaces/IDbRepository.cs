using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.Repository.Interfaces
{
    public interface IDbRepository<T> : IRepository<T> where T : class
    {
        void BeginTransaction();
        void Commit();
        void Rollback();
        void CloseConnection();
    }
}
