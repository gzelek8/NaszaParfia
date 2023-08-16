using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.ValueObjects
{
    public class GeoJsonPoint
    {
        public double Longitude { get; set; }
        public double Latitude { get; set; }
    }
}