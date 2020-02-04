using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace WorkerSample
{
    public class Worker1 : BackgroundService
    {
        private readonly ILogger<Worker1> _logger;

        public Worker1(ILogger<Worker1> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker1 running at: {time}", DateTimeOffset.Now);
                await Task.Delay(6000, stoppingToken);
            }
        }
    }
}
