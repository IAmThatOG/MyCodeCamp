using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using MyCodeCamp.Data;
using MyCodeCamp.Data.repositories;
using MyCodeCamp.Data.repositories.implementations;
using MyCodeCamp.Domain.services.implementations;
using MyCodeCamp.Domain.services;
using Newtonsoft.Json;

namespace MyCodeCamp
{
    public class Startup
    {
        private readonly IConfiguration _config;
        public Startup(IConfiguration configuration)
        {
            _config = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc()
                    .SetCompatibilityVersion(CompatibilityVersion.Version_2_1)
                    .AddJsonOptions(opt => opt.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);
            
            var connectionString = _config.GetConnectionString("Conn");
            var dbConnection = "Server=(local);Database=MyCodeCampDb;User Id=sa;Password=Gabbyg89@.com;";
            services.AddDbContext<CampContext>(options => options.UseSqlServer(dbConnection));

            services.AddScoped<ICampRepository, CampRepository>();
            services.AddScoped<ICampService, CampService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
