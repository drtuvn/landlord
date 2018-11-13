using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Landlord.Models
{
    [Flags]
    public enum CashFlowType
    {
        Unknown = 0x0000,
        Income = 0x0001,
        OtherIncome = 0x0002,
        Mortgage = 0x0004,
        HOAFee = 0x0008,
        UtilityTrash = 0x0010,
        ElectricityFee = 0x0020,
        GasFee = 0x0040,
        WaterSewerFee = 0x0080,
        RepairFee = 0x0100,
        InsuranceFee = 0x0200,
        OtherExpense = 0x1000,
    }
    public class CashFlow
    {
        public Guid ID { get; set; }
        public double Amount { get; set; }
        public string Comment { get; set; }
        public CashFlowType Type { get; set; }
        public DateTime Date { get; set; }
    }
    
}
