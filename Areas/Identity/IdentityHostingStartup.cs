using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Tunrecrute.Areas.Identity.Data;
using Tunrecrute.Data;

[assembly: HostingStartup(typeof(Tunrecrute.Areas.Identity.IdentityHostingStartup))]
namespace Tunrecrute.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<TunrecruteContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("TunrecruteContextConnection")));

                services.AddDefaultIdentity<User>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<TunrecruteContext>();
            });
        }
    }
}