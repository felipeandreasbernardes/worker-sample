using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace WorkerSample.IoC
{
    public static class DependecyInjection
    {
        public static IServiceCollection ConfigureWorkerService(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddHostedService<Worker>();

            return services;
        }
    }
}
