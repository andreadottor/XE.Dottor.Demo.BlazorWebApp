namespace Dottor.Earthquake.Services
{
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class DependencyInjection
    {
        public static IServiceCollection AddEarthquake(this IServiceCollection services)
        {
            services.AddTransient<IEarthquakeService, EarthquakeUsgsProxyService>();

            return services;
        }
    }
}
