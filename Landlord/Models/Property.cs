using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Landlord.Models
{
    public class Property
    {
        public Guid ID { get; set; }
        public string PropertyName { get; set; }
        public string Address { get; set; }
        public double PurchasedPrice { get; set; }
        public double CurrentValue { get; set; }
        public double Mortgage { get; set; }
        public PropertyInfo PropertyInformation { get; set; }
    }
}
