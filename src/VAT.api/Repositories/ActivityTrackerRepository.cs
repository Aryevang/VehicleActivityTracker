using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VAT.api.AbstractServices;
using VAT.api.DataAccess;
using VAT.api.Models;
using Microsoft.EntityFrameworkCore;

namespace VAT.api.Repositories
{
   public class ActivityTrackerRepository : IActivityTracker<VMT_County>
   {
      private readonly DataContext _ctx;

      public ActivityTrackerRepository(DataContext ctx = null)
      {
         _ctx = ctx;
      }

      public async Task<bool> AddDataAsync(VMT_County data)
      {
         try
         {
            await _ctx.VMT_Countys.AddAsync(data);
            //If there is any issue in the database side this method will reach the catch and the api wi return false.
            await _ctx.SaveChangesAsync();
            
            return true;
         }
         catch (System.Exception)
         {
             return false;
             throw;
         }
      }

      public async Task<bool> DeleteDataAsync(int id)
      {
         try
         {
             _ctx.VMT_Countys.Remove(new VMT_County {ID = id});
             await _ctx.SaveChangesAsync();
             return true;
         }
         catch (System.Exception)
         {
             return false;
             throw;
         }
      }

      public async Task<VMT_County> GetDataAsync(int id)
      {
         try
         {
             var result =await _ctx.VMT_Countys.FindAsync( new VMT_County{ID=id});
             if(result!=null)
               return result;
             //A blank entity means the search didn't find any result.  
             return new VMT_County();
         }
         catch (System.Exception)
         {
             throw;
         }
      }

      public async Task<IEnumerable<VMT_County>> Get_All_dataAsync()
      {
         try
         {
             var result = await _ctx.VMT_Countys.ToListAsync();
             return result;
         }
         catch (System.Exception)
         {
             throw;
         }
      }

      public async Task<bool> UpdateDataAsync(int id, VMT_County newData)
      {
         try
         {
             var dataToUdate =await _ctx.VMT_Countys.FindAsync(new VMT_County{ID=id});
             if(dataToUdate !=null)
             {
                newData.ID = dataToUdate.ID;
                dataToUdate = newData;
                
                await _ctx.SaveChangesAsync();
                return true;
             }
             return false;
        
         }
         catch (System.Exception)
         {
            return false;
             throw;
         }
      }
   }
}