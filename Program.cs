using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using TCC;
using TCC.Db;
using System.Text.Json.Serialization;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;


var builder = WebApplication.CreateBuilder(args);

Startup.CreateServices(builder);

// Add services to the container.
//builder.Services.AddControllersWithViews();
//builder.Services.AddControllers().AddNewtonsoftJson();
//builder.Services.AddRazorPages();
//builder.Services.AddRazorPages().AddRazorRuntimeCompilation();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.UseEndpoints(endpoints =>
{
    endpoints.MapRazorPages();
});

app.Run();
