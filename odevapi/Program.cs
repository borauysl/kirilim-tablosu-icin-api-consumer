using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using odevapi; 
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Microsoft.Extensions.Http;

public class Program
{
    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
    Host.CreateDefaultBuilder(args)
        .ConfigureServices((hostContext, services) =>
        {
            services.AddHostedService<DataSyncWorker>(); 
            services.AddHttpClient();
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseMySql(
                    hostContext.Configuration.GetConnectionString("DefaultConnection"),
                    new MySqlServerVersion(new Version(8, 0, 21))
                ));
            services.AddHttpClient(); 
        });
}