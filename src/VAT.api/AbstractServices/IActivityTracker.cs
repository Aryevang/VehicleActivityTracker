using System.Collections.Generic;
using System.Threading.Tasks;
using VAT.api.Models;

namespace VAT.api.AbstractServices
{
    public interface IActivityTracker<T>
    {
         Task<T> GetDataAsync(int id);
         Task<IEnumerable<T>> Get_All_dataAsync();
         Task<bool> AddDataAsync(T data);
         Task<bool> UpdateDataAsync(T newData);
         Task<bool> DeleteDataAsync(int id);
    }
}