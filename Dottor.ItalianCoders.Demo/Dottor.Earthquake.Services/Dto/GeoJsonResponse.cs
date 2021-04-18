namespace Dottor.Earthquake.Services.Dto
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class GeoJsonResponse
    {
        public string Type { get; set; }
        public Metadata Metadata { get; set; }
        public List<Feature> Features { get; set; }
        public List<double> Bbox { get; set; }
    }



    







}
