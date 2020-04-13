using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TipCalculator.Models
{
    public class TipModel
    { 
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Amount cannot be zero or negative")]
        public double Amount { get; set; }

        [Required]
        public int Percentage { get; set; }

        [Required]
        [Range(1, 100, ErrorMessage = "Invalid number of people")]
        public int PeopleCount { get; set; }
    }
}
