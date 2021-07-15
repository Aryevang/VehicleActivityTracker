using Microsoft.EntityFrameworkCore;
using VAT.api.Models;

namespace VAT.api.DataAccess
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){  }

        public DbSet<VMT_County> VMT_Countys { get; set; }
    }
}