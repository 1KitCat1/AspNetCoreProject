using AspNetCoreProject.Service;
using AspNetCoreProject.Domain.Entities;
using AspNetCoreProject.Domain.Repositories.Abstract;
using AspNetCoreProject.Domain.Repositories.EntityFramework;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreProject.Domain;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreProject
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
            //connect configurations from appsettings
            Configuration.Bind("Project", new Config());
            
            services.AddTransient<ITextFieldsRepository, EFTextFieldRepository>();
            services.AddTransient<IServiceItemsRepository, EFServiceItemRepository>();
            services.AddTransient<DataManager>();

            //connecting DB
            services.AddDbContext<AppDbContext>(x => x.UseSqlServer(Config.ConnectionString));
            services.AddRazorPages();
            services.AddControllersWithViews().SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_3_0)
                .AddSessionStateTempDataProvider();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
