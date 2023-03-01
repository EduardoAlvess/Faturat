using Microsoft.EntityFrameworkCore;
using TCC.Areas.Identity.Data;
using TCC.Providers;
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

        public static void CreateServices(WebApplicationBuilder builder)
        {
            var env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")
                    ?? Environment.GetEnvironmentVariable("DOTNET_ENVIRONMENT");

            Configuration = builder.Configuration.AddJsonFile("AppSettings.json", false, true)
                                   .AddJsonFile($"AppSettings.{env}.json", true, false)
                                   .Build();

            ConfigureServices(builder, env == "DEVELOPMENT");
        }

        private static void ConfigureServices(WebApplicationBuilder builder, bool isDevelopment)
        {
            builder.Services.AddSingleton(Configuration);

            var connectionString = Configuration.GetConnectionString("Default");

            builder.Services.AddDbContext<IDatabaseContext, DatabaseContext>(dbContextOptions => 
            dbContextOptions.UseMySql(connectionString, new MySqlServerVersion(new Version(5, 6, 0)))
                            .EnableSensitiveDataLogging()
                            .EnableDetailedErrors());

            builder.Services.AddDefaultIdentity<User>(options => 
            {
                options.SignIn.RequireConfirmedAccount = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequiredLength = 6;
            }).AddEntityFrameworkStores<DatabaseContext>();

            builder.Services.AddTransient<IUserProvider, UserProvider>();
            builder.Services.AddTransient<IGoalsProvider, GoalsProvider>();
            builder.Services.AddTransient<IAccountProvider, AccountProvider>();
            builder.Services.AddTransient<ICategoryProvider, CategoryProvider>();
            builder.Services.AddTransient<ITransactionsProvider, TransactionsProvider>();

            builder.Services.AddRazorPages().AddRazorRuntimeCompilation();
            builder.Services.AddControllers().AddNewtonsoftJson();
            builder.Services.AddControllersWithViews();
            builder.Services.AddHttpContextAccessor();
            builder.Services.AddRazorPages();
            builder.Services.AddMemoryCache();
        }
    }
}
