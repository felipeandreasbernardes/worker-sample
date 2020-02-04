using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WorkerSample.Configuration;

namespace WorkerSample
{
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
                    IConfiguration configuration;

                    var serviceProvider = services.BuildServiceProvider();

                    configuration = serviceProvider.GetRequiredService<IConfiguration>();

                    WorkerConfiguration workerConfiguration = new WorkerConfiguration(services, configuration);

                    services.AddSingleton(workerConfiguration);

                    workerConfiguration.Configure();
                });
    }
}
