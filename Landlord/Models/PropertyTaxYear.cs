using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Landlord.Models
{
    public class PropertyTaxYear
    {
        public Guid ID { get; set; }
        public int Year { get; set; }
        public double Tax { get; set; }
    }
}
