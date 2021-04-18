namespace Dottor.Earthquake.Services.Dto
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Geometry
    {
        public string Type { get; set; }
        public List<double> Coordinates { get; set; }
    }
}
