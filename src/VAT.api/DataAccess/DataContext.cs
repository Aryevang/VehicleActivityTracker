using System;
using Microsoft.EntityFrameworkCore;
using VAT.api.Models;

namespace VAT.api.DataAccess
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){  }

        public DbSet<VMT_County> VMT_Countys { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            #region "Seeding Database"
            builder.Entity<VMT_County>().HasData(
                new { ID = 1, county_fips=1001, county_name="Autauga", state_name="Alabama", date= new DateTime(2020,5,8), county_vmt=3550000, baseline_jan_vmt=3571446,percent_change_from_jan=-0.6f, mean7_county_vmt=2790000f,mean7_percent_change_from_jan=-21.88f,date_at_low= new DateTime(2020,4,12), mean7_county_vmt_at_low=1542857.14f, percent_change_from_low=80.83f},
                new { ID = 2, county_fips=1001, county_name="Autauga", state_name="Alabama", date= new DateTime(2020,5,7), county_vmt=2970000, baseline_jan_vmt=3571446,percent_change_from_jan=-16.84f, mean7_county_vmt=2724285.71f,mean7_percent_change_from_jan=-23.72f,date_at_low= new DateTime(2020,4,12), mean7_county_vmt_at_low=1542857.14f, percent_change_from_low=76.57f},
                new { ID = 3, county_fips=1001, county_name="Autauga", state_name="Alabama", date= new DateTime(2020,5,6), county_vmt=2680000, baseline_jan_vmt=3571446,percent_change_from_jan=-24.96f, mean7_county_vmt=2724285.71f,mean7_percent_change_from_jan=-25.96f,date_at_low= new DateTime(2020,4,12), mean7_county_vmt_at_low=1542857.14f, percent_change_from_low=71.39f},
                new { ID = 4, county_fips=1001, county_name="Autauga", state_name="Alabama", date= new DateTime(2020,5,5), county_vmt=2720000, baseline_jan_vmt=3571446,percent_change_from_jan=-23.84f, mean7_county_vmt=2561428.57f,mean7_percent_change_from_jan=-28.28f,date_at_low= new DateTime(2020,4,12), mean7_county_vmt_at_low=1542857.14f, percent_change_from_low=66.02f},
                new { ID = 5, county_fips=1001, county_name="Autauga", state_name="Alabama", date= new DateTime(2020,5,4), county_vmt=2390000, baseline_jan_vmt=3571446,percent_change_from_jan=-33.08f, mean7_county_vmt=2515714.29f,mean7_percent_change_from_jan=-29.56f,date_at_low= new DateTime(2020,4,12), mean7_county_vmt_at_low=1542857.14f, percent_change_from_low=63.06f}
            );
            #endregion
        }
    }
}