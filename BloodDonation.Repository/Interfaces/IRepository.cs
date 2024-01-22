using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.Repository.Interfaces
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        void Update(T entity, string condition);
        void Delete(T entity, string condition);
        int GetNewID(T entity);
        T Get(T entity, string condition);
        List<T> GetAll(T entity);
        List<T> Find(T entity, string condition);
    }
}
