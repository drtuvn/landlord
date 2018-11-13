using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Landlord.Models
{
    public class PropertyInfo
    {
        public Guid ID { get; set; }
        public double HOAFee { get; set; }
        public ICollection<PropertyTaxYear> PropertyTaxInfos { get; set; }
        public Equity EquityInfo { get; set; }
    }
}
