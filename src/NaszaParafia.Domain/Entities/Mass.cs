using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaszaParafia.Domain.Entities
{
    public class Mass
    {
        public Guid Id { get; set; }
        public string Intention { get; set; }
        public DateTime Date { get; set; }
        public Guid ParishId { get; set; }
        public Parish Parish { get; set; }
        public Guid PriestId { get; set; }
        public Priest Priest { get; set; }
        public Guid ParaffinId { get; set; }
        public Paraffin Paraffin { get; set; }
    }
}