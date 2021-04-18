namespace Dottor.Earthquake.Services
{
    using Dottor.Earthquake.Services.Dto;
    using Dottor.Earthquake.Services.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Net.Http.Json;
    using System.Text;
    using System.Threading.Tasks;

    public class EarthquakeUsgsProxyService : IEarthquakeService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public EarthquakeUsgsProxyService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<EarthquakeModel> GetDetailsAsync(string id)
        {
            var httpClient = _httpClientFactory.CreateClient();

            var response = await httpClient.GetFromJsonAsync<Feature>($"https://earthquake.usgs.gov/earthquakes/feed/v1.0/detail/{id}.geojson");

            return Map(response);
        }

        public async Task<ICollection<EarthquakeModel>> GetPastDayAllAsync()
        {
            var httpClient = _httpClientFactory.CreateClient();

            var response = await httpClient.GetFromJsonAsync<GeoJsonResponse>("https://earthquake.usgs.gov/earthquakes/feed/v1.0/summary/all_day.geojson");

            var result = new List<EarthquakeModel>();

            foreach (var item in response.Features)
            {
                EarthquakeModel earthquake = Map(item);
                result.Add(earthquake);
            }

            return result;
        }

        private static EarthquakeModel Map(Feature item)
        {
            return new()
            {
                Coordinates = item.Geometry.Coordinates,
                Id = item.Id,
                Mag = item.Properties.Mag,
                Place = item.Properties.Place,
                Time = DateTimeOffset.FromUnixTimeMilliseconds(item.Properties.Time),
                Title = item.Properties.Title,
                Url = item.Properties.Url
            };
        }
    }
}
