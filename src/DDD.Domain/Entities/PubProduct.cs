using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Entities
{
    public class PubProduct
    {
        public Guid PubId { get; set; }
        public Pub Pub { get; set; }
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
        public Guid? DiscountId { get; set; }
        public Discount? Discount { get; set; } 
    }
}