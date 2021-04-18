namespace Dottor.Earthquake.Services.Models
{
    using System;
    using System.Collections.Generic;

    public class EarthquakeModel
    {
        public string Id { get; set; }
        public double Mag { get; set; }
        public string Title { get; set; }
        public string Place { get; set; }
        public string Url { get; set; }
        public List<double> Coordinates { get; set; }
        public DateTimeOffset Time { get; set; }
    }
}
