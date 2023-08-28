using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaszaParafia.API.Contracts.Paraffin.Requests
{
    public class ParaffinCreateUpdate
    {
        [Required]
        [MinLength(3)]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(50)]
        public string LastName { get; set; }

        [EmailAddress]
        [Required]
        public string EmailAddress { get; set; }

        public string Phone { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }
    }
}