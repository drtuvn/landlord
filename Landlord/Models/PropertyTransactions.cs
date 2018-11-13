using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Landlord.Models
{
    public class PropertyTransactions
    {
        public Guid ID { get; set; }
        public Guid PropertyID { get; set; }
        public Guid TenanPropertiesID { get; set; }
        public CashFlow CashFlow { get; set; }
    }
}
