using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace VAT.DataAccess
{
    public interface IDataService 
    {
         Task<TEntity> GetAsync<TEntity>(int id) where TEntity : class;
         Task<IEnumerable<TEntity>> GetAllAsync<TEntity>() where TEntity : class;
         Task<TEntity> AddAsync<TEntity>(TEntity data) where TEntity : class;
         Task<TEntity> UpdateAsync<TEntity>(TEntity data) where TEntity : class;
         Task<TEntity> DeleteAsync<TEntity>(int id) where TEntity : class;
         Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}