using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.ValueObjects;

namespace Backend.Entities
{
    public class Pub
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public GeoJsonPoint Location { get; set; }
        public string Address { get; set; }
        public List<PubProduct> Products { get; set; } = new List<PubProduct>();
        public int AvailablePlaces { get; set; }
    }
}