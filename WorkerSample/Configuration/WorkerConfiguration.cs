using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WorkerSample.IoC;

namespace WorkerSample.Configuration
{
    public class WorkerConfiguration
    {
        private readonly IServiceCollection _services;
        private readonly IConfiguration _configuration;

        public WorkerConfiguration(IServiceCollection services, IConfiguration configuration)
        {
            _services = services;
            _configuration = configuration;
        }

        public IServiceCollection Configure()
        {
            return _services.ConfigureWorkerService(_configuration);
        }
    }
}
