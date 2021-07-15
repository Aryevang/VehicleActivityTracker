using System.Collections.Generic;
using System.Threading.Tasks;
using VAT.api.Models;

namespace VAT.api.AbstractServices
{
    public interface IActivityTracker
    {
         Task<VMT_County> GetData(int id);
         Task<IEnumerable<VMT_County>> Get_All_data();
         Task<bool> AddData(VMT_County data);
         Task<bool> UpdateData(VMT_County data);
         Task<bool> DeleteData(int id);
    }
}