using BusSystem.Configuration;
using BusSystem.Data.Repository;
using BusSystem.Entity.IdentityAccess;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ReflectionIT.Mvc.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Extensions.Logging;
using BusSystem.Services.Interfaces;
using BusSystem.Services.Implements;

namespace BusSystem
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        [Obsolete]
        public void ConfigureServices(IServiceCollection services)
        {
            // connect db
            string connectionString = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<BusSystemDbContext>(c => c.UseSqlServer(connectionString));

            // add depency
            Dependency.Configuration(services);

            // add identity
            services.AddIdentity<User, Role>(options =>
            {
                options.Password.RequireDigit = false;
                options.SignIn.RequireConfirmedEmail = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;
            }).AddEntityFrameworkStores<BusSystemDbContext>();

            // auto mapper
            services.AddAutoMapper(typeof(AutoMapperProfile));

            // custom link account
            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = $"/admin/auth/login";
                options.LogoutPath = $"/admin/auth/logout";
                options.AccessDeniedPath = $"/admin/auth/accessDenied";
            });
            services.AddHttpContextAccessor();
            services.AddControllersWithViews();
            services.AddRazorTemplating();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddFile("Logs/mylog-{Date}.txt");
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.Use(async (context, next) =>
            {
                await next();
                if (context.Response.StatusCode == 404)
                {
                    context.Request.Path = "/";
                    await next();
                }
            });
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization(); // Add it here


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                //endpoints.MapControllerRoute(
                //    name: "default",
                //    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }

    }
}
