using BloodDonation.Repository.Implementation;
using BloodDonation.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.SystemOperations
{
    public abstract class SystemOperationBase
    {
        protected IDbRepository<IEntity> genericRepository;

        //hmm potencijalno bolje preko genericsa
        public object Result { get; protected set; }
        public SystemOperationBase()
        {
            genericRepository = new GenericDbRepository();
        }
        public void ExecuteTemplate(IEntity entity) {
            try
            {
                genericRepository.BeginTransaction();
                ExecuteConcreteOperation(entity);
                genericRepository.Commit();
            }
            catch (Exception ex)
            {
                genericRepository.Rollback();
                Debug.WriteLine(">>>" + ex.Message);
                throw;
            }
            finally { 
                genericRepository.CloseConnection();
            }
        }
        protected abstract void ExecuteConcreteOperation(IEntity entity);
    }
}
