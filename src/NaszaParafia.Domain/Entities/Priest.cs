using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaszaParafia.Domain.Entities
{
    public class Priest
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid ParishId { get; set; }
        public Parish Parish { get; set; }
        public ICollection<Mass> Masses { get; set; }
    }
}