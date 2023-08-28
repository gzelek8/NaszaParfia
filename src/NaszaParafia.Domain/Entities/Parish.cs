using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NaszaParafia.Domain.ValueObjects;

namespace NaszaParafia.Domain.Entities
{
    public class Parish
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public GeoJsonPoint Location { get; set; }
        public ICollection<Priest> Priests { get; set; } = new ICollection<Priest>();
        public ICollection<Paraffin> Parishioners { get; set; } = new ICollection<Paraffin>();
        public ICollection<Mass> Masses { get; set; } = new ICollection<Mass>();
    }
}