﻿using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TCC.Areas.Identity.Data;
using TCC.Db.Authorization;

[assembly: HostingStartup(typeof(TCC.Areas.Identity.IdentityHostingStartup))]
namespace TCC.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<AuthorizationDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("AuthorizationDbContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<AuthorizationDbContext>();
            });
        }
    }
}
