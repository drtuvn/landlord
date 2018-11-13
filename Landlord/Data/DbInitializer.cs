using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Landlord.Models;

namespace Landlord.Data
{
    public class DbInitializer
    {
        public static void Initialize(LandlordContext context)
        {
            context.Database.EnsureCreated();

            // Look for any Propertys.
            if (context.Properties.Any())
            {
                return;   // DB has been seeded
            }

            var propertyTaxInfos = new PropertyTaxYear[]
            {
                new PropertyTaxYear{ Tax = 1000, Year= 2018},
                new PropertyTaxYear{ Tax = 1001, Year= 2019},
            };
            foreach (PropertyTaxYear s in propertyTaxInfos)
            {
                context.PropertyTaxYears.Add(s);
            }
            context.SaveChanges();

            var Propertys = new Property[]
            {
                new Property{PropertyName="130th",Address="130th",PurchasedPrice=1, CurrentValue=1,Mortgage=0.5,
                    PropertyInformation = new PropertyInfo{ EquityInfo = new Equity{ Bank = "FirstTech" } } },
                new Property{PropertyName="125th",Address="125th",PurchasedPrice=2, CurrentValue=1,Mortgage=0.5, PropertyInformation = new PropertyInfo{ EquityInfo = new Equity{ Bank = "FirstTech" } } },
                new Property{PropertyName="Corona",Address="Corona",PurchasedPrice=3, CurrentValue=1,Mortgage=0.5, PropertyInformation = new PropertyInfo{ EquityInfo = new Equity{ Bank = "FirstTech" } } },
                new Property{PropertyName="Ashland",Address="Ashland",PurchasedPrice=2, CurrentValue=1,Mortgage=0.5, PropertyInformation = new PropertyInfo{ EquityInfo = new Equity{ Bank = "FirstTech" } } },
                new Property{PropertyName="Wrenfield",Address="Wrenfield",PurchasedPrice=2, CurrentValue=1,Mortgage=0.5, PropertyInformation = new PropertyInfo{ EquityInfo = new Equity{ Bank = "FirstTech" } } },
                new Property{PropertyName="Rock",Address="Justice",PurchasedPrice=4, CurrentValue=1,Mortgage=0.5, PropertyInformation = new PropertyInfo{ EquityInfo = new Equity{ Bank = "FirstTech" } } },
                new Property{PropertyName="Coburg",Address="Norman",PurchasedPrice=3, CurrentValue=1,Mortgage=0.5, PropertyInformation = new PropertyInfo{ EquityInfo = new Equity{ Bank = "FirstTech" } } },
                new Property{PropertyName="Melody",Address="Olivetto",PurchasedPrice=5, CurrentValue=1,Mortgage=0.5,}
            };
            foreach (Property s in Propertys)
            {
                context.Properties.Add(s);
            }
            context.SaveChanges();

            var tenants = new Tenant[]
            {
            new Tenant{FirstName="Lucas", Deposit=3},
            new Tenant{FirstName="Sham", Deposit=3},
            new Tenant{FirstName="Martha", Deposit=3},
            new Tenant{FirstName="Diane", Deposit=3},
            new Tenant{FirstName="Sean", Deposit=3},
            new Tenant{FirstName="NotSure", Deposit=3},
            new Tenant{FirstName="TuAnna", Deposit=3},
            };
            foreach (var c in tenants)
            {
                context.Tenants.Add(c);
            }
            context.SaveChanges();

            var propertyTenants = new TenantProperties[]
            {
            new TenantProperties{Tenants=tenants.Take(1).ToArray(), RentAmount=3},
            new TenantProperties{Tenants=tenants.Skip(1).Take(1).ToArray(), RentAmount=3},
            new TenantProperties{Tenants=tenants.Skip(2).Take(1).ToArray(), RentAmount=3},
            new TenantProperties{Tenants=tenants.Skip(3).Take(1).ToArray(), RentAmount=3},
            new TenantProperties{Tenants=tenants.Skip(4).Take(1).ToArray(), RentAmount=3},
            new TenantProperties{Tenants=tenants.Skip(5).Take(1).ToArray(), RentAmount=3},
            new TenantProperties{Tenants=tenants.TakeLast(1).ToArray(), RentAmount=3},
            };
            foreach (var c in propertyTenants)
            {
                context.TenantProperties.Add(c);
            }
            context.SaveChanges();


            var PropertyTransactionss = new PropertyTransactions[]
            {
            new PropertyTransactions{CashFlow = new CashFlow{ Type = CashFlowType.Income, Amount = 1 } },
            new PropertyTransactions{CashFlow = new CashFlow{ Type = CashFlowType.Income, Amount = 2 } },
            new PropertyTransactions{CashFlow = new CashFlow{ Type = CashFlowType.Income, Amount = 3 } },
            new PropertyTransactions{CashFlow = new CashFlow{ Type = CashFlowType.Income, Amount = 4 } },
            new PropertyTransactions{CashFlow = new CashFlow{ Type = CashFlowType.Income, Amount = 5 } },
            new PropertyTransactions{CashFlow = new CashFlow{ Type = CashFlowType.Income, Amount = 6 } },
            new PropertyTransactions{CashFlow = new CashFlow{ Type = CashFlowType.Income, Amount = 7 } },
            };
            foreach (PropertyTransactions e in PropertyTransactionss)
            {
                context.PropertiesTransactions.Add(e);
            }
            context.SaveChanges();
        }
    }
}
