using System.Collections.Generic;
using System.Threading.Tasks;
using VAT.api.AbstractServices;
using VAT.api.Models;

namespace VAT.api.Repositories
{
   public class ActivityTrackerRepository : IActivityTracker
   {
      public Task<bool> AddData(VMT_County data)
      {
         throw new System.NotImplementedException();
      }

      public Task<bool> DeleteData(int id)
      {
         throw new System.NotImplementedException();
      }

      public Task<VMT_County> GetData(int id)
      {
         throw new System.NotImplementedException();
      }

      public Task<IEnumerable<VMT_County>> Get_All_data()
      {
         throw new System.NotImplementedException();
      }

      public Task<bool> UpdateData(VMT_County data)
      {
         throw new System.NotImplementedException();
      }
   }
}