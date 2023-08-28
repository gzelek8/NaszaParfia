using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaszaParafia.Domain.ValueObjects
{
    public class GeoJsonPoint
    {
        public double Longitude { get; set; }
        public double Latitude { get; set; }
    }
}