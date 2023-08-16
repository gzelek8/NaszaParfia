using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Entities
{
    public class Discount
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public decimal Value { get; set; }
        public DateTime DateTime { get; set; }
        public List<PubProduct> PubProducts { get; set; } = new List<PubProduct>();

    }
}