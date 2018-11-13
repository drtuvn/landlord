using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Landlord.Models
{
    public class Equity
    {
        public Guid ID { get; set; }
        public double EquityAmount { get; set; }
        public string Type { get; set; }
        public string Bank { get; set; }
    }
}
