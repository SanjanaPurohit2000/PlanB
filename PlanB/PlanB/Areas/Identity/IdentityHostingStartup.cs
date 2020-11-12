using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PlanB.Areas.Identity.Data;
using PlanB.Data;

[assembly: HostingStartup(typeof(PlanB.Areas.Identity.IdentityHostingStartup))]
namespace PlanB.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<PlanBDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("PlanBDbContextConnection")));

                services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false)
                    .AddEntityFrameworkStores<PlanBDbContext>();

            });
        }
    }
}