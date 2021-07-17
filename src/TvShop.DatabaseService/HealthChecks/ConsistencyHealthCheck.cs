using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace TvShop.DatabaseService.HealthChecks
{
    public class ConsistencyHealthCheck : IHealthCheck
    {
        public async Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = new CancellationToken())
        {
            bool isHealthy = await IsDbConsistentAsync();

            return isHealthy
                ? HealthCheckResult.Healthy("Database consistency is OK")
                : HealthCheckResult.Unhealthy("Database consistency ERROR");
        }

        private static Task<bool> IsDbConsistentAsync()
        {
            return Task.FromResult(true);
        }
    }
}
