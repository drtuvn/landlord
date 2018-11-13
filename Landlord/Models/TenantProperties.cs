using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Landlord.Models
{
    public class TenantProperties
    {
        public Guid ID { get; set; }
        //public Guid TenantID { get; set; }
        public ICollection<Tenant> Tenants { get; set; }

        public Guid PropertyID { get; set; }
        public double RentAmount { get; set; }
        public DateTime MoveInDate { get; set; }
        public DateTime RenewalDate { get; set; }
    }
}
