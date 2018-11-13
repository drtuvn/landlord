using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Landlord.Models
{
    public class Tenant
    {
        public Guid ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime DOB { get; set; }
        public string DriverLicense { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public string RenterInsurance { get; set; }
        public double Rent { get; set; }
        public double Deposit { get; set; }
        public DateTime LeaseBegin { get; set; }
        public DateTime LeaseEnd { get; set; }
        public string Comment { get; set; }
        public DateTime Date { get; set; }
    }
}
