using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using TCC.Db;

namespace TCC
{
    public class Startup
    {
        public static IConfigurationRoot Configuration { get; set; }

        public Startup(IConfigurationRoot configuration)
        {
            Configuration = configuration;
        }

        public static void CreateServices(string[] args)
        {
            ServiceCollection serviceCollection = new ServiceCollection();
           
            var env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")
                    ?? Environment.GetEnvironmentVariable("DOTNET_ENVIRONMENT");

            Configuration = new ConfigurationBuilder().AddJsonFile("AppSettings.json", false, true)
                                                      .AddJsonFile($"AppSettings.{env}.json", true, false)
                                                      .Build();

            ConfigureServices(serviceCollection, env == "DEVELOPMENT");

        }

        private static void ConfigureServices(IServiceCollection services, bool isDevelopment)
        {
            services.AddSingleton(Configuration);
            //services.Configure<AppSettings>(Configuration.GetSection("AppSettings"));

            var connectionString = Configuration.GetConnectionString("Default");

            services.AddDbContext<IDatabaseContext, DatabaseContext>(dbContextOptions => 
            dbContextOptions.UseMySql(connectionString, new MySqlServerVersion(new Version(5, 6, 0)))
                                        .EnableSensitiveDataLogging()
                                        .EnableDetailedErrors());
        }
    }
}
