using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TipCalculator.Models
{
    public class TipModel
    {
        public double Amount { get; set; }

        public int Percentage { get; set; }

        public int PeopleCount { get; set; }
    }
}
