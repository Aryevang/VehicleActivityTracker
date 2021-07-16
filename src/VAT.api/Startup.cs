using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using VAT.api.AbstractServices;
using VAT.api.DataAccess;
using VAT.api.Models;
using VAT.api.Repositories;


namespace VAT.api
{
   public class Startup
   {
      public Startup(IConfiguration configuration)
      {
         Configuration = configuration;
      }

      public IConfiguration Configuration { get; }

      // This method gets called by the runtime. Use this method to add services to the container.
      public void ConfigureServices(IServiceCollection services)
      {
         services.AddControllers();
         services.AddSwaggerGen(c =>
         {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "VAT.api", Version = "v1" });
         });


         var server = Configuration["DBServer"] ?? "localhost";
         var port = Configuration["DBPort"] ?? "1433";
         var user = Configuration["DBUser"] ?? "sa";
         var password = Configuration["DBPasssword"] ?? "Adm1n123";
         var database = Configuration["Database"] ?? "VMT";

         services.AddDbContext<DataContext>(options =>
             options.UseSqlServer($"Data Source={server},{port};Initial Catalog={database};Integrated Security=true;"));
             //options.UseSqlServer($"Server={server},{port};Initial Catalog={database}; Integrated Security=true;"));

         services.AddScoped<IActivityTracker<VMT_County>, ActivityTrackerRepository>();
      }

      // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
      public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
      {
        //This approach will create the DB and the table at the first run.
         using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
         {
            var context = serviceScope.ServiceProvider.GetRequiredService<DataContext>();
            context.Database.EnsureCreated();
         }          
         if (env.IsDevelopment())
         {
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "VAT.api v1"));
         }

         app.UseHttpsRedirection();

         app.UseRouting();

         app.UseAuthorization();

         app.UseEndpoints(endpoints =>
         {
            endpoints.MapControllers();
         });
      }
   }
}
