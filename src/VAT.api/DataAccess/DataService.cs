using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using VAT.api.Models;

namespace VAT.DataAccess
{
   public class DataService : IDataService
   {
      public DataService()
      {
          
      }

      public Task<TEntity> AddAsync<TEntity>(TEntity data) where TEntity : class
      {
         throw new System.NotImplementedException();
      }

      public Task<TEntity> DeleteAsync<TEntity>(int id) where TEntity : class
      {
         throw new System.NotImplementedException();
      }

      public Task<IEnumerable<TEntity>> GetAllAsync<TEntity>() where TEntity : class
      {
         throw new System.NotImplementedException();
      }

      public Task<TEntity> GetAsync<TEntity>(int id) where TEntity : class
      {
         throw new System.NotImplementedException();
      }

      public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
      {
         throw new System.NotImplementedException();
      }

      public Task<TEntity> UpdateAsync<TEntity>(TEntity data) where TEntity : class
      {
         throw new System.NotImplementedException();
      }
   }

}