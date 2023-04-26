using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;


using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using UdayChinhamoraWebsite.Models;
using Microsoft.Data.SqlClient;
using System.Diagnostics.Metrics;
using System;

using Moq;
using UdayChinhamoraWebsite.Repository;

namespace UdayChinhamoraWebsite
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<TicketContext>
                (options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            
            services.AddSingleton<ITicketRepository, TicketRepository>();
            services.AddMvc();
            services.AddRazorPages();

            services.AddIdentity<ApplicationUser, IdentityRole>()
              .AddEntityFrameworkStores<TicketContext>();

            services.AddControllersWithViews();
            services.ConfigureApplicationCookie(config =>
            {
                config.LoginPath = "/login";
            });
#if DEBUG

            services.AddScoped<IAccountRepository, AccountRepository>();

#endif

        }
        public void Configure(WebApplication app, IWebHostEnvironment env, TicketContext dbContext)
        {
            dbContext.Database.EnsureCreated();
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");

                app.UseHsts();
            }

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                app.UseHttpsRedirection();
                app.UseStaticFiles();
                app.UseRouting();
                app.UseAuthorization();
                app.MapRazorPages();
                app.UseAuthorization();
                app.UseMvc();
                app.Run();
            });
    }
    }
}