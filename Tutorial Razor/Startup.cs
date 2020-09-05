using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Tutorial_Razor.Data;
using Tutorial_Razor.Models;
using Inventory.Models;
using Microsoft.AspNetCore.Identity;

namespace Tutorial_Razor
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
            services.AddRazorPages().AddRazorPagesOptions(options =>
            {
                options.Conventions.AuthorizePage("/Index");
                options.Conventions.AuthorizePage("/Product/Edit");
                options.Conventions.AuthorizePage("/Employee/Delete");
                options.Conventions.AuthorizePage("/Employee/Edit");
                options.Conventions.AuthorizePage("/Product/Delete");
                options.Conventions.AuthorizePage("/Supplier/Edit");
                options.Conventions.AuthorizePage("/Supplier/Delete");



                options.Conventions.AllowAnonymousToPage("/Index");
            });

            services.AddIdentity<AppUser, AppRole>(options =>
            {
                
                options.User.RequireUniqueEmail = true;
                

            }).AddEntityFrameworkStores<IdentityAppContext>().AddDefaultTokenProviders();

            services.AddDbContext<IdentityAppContext>(cfg =>
            {

              cfg.UseSqlServer(Configuration.GetConnectionString("Tutorial_RazorContext"));
               
            });
            services.ConfigureApplicationCookie(options => options.LoginPath = "/Account/Login");

            services.AddDbContext<Tutorial_RazorContext>(options =>
             options.UseSqlServer(Configuration.GetConnectionString("Tutorial_RazorContext")));

            services.AddDbContext<Tutorial_RazorContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("Tutorial_RazorContext")));




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
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
