namespace Dottor.Earthquake.Services
{
    using Dottor.Earthquake.Services.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IEarthquakeService
    {

        Task<ICollection<EarthquakeModel>> GetPastDayAllAsync();
        Task<EarthquakeModel> GetDetailsAsync(string id);

    }
}
