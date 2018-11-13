using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using Landlord.Models;

namespace Landlord.Data
{
    public class LandlordContext : DbContext
    {
        public LandlordContext(DbContextOptions<LandlordContext> options) : base(options)
        {
        }
        public DbSet<CashFlow> CashFlows { get; set; }
        public DbSet<Equity> Equities { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<PropertyInfo> PropertyInfos { get; set; }
        public DbSet<PropertyTaxYear> PropertyTaxYears { get; set; }
        public DbSet<PropertyTransactions> PropertiesTransactions { get; set; }
        
        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<TenantProperties> TenantProperties { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CashFlow>().ToTable("CashFlow");
            modelBuilder.Entity<Equity>().ToTable("Equity");
            modelBuilder.Entity<Property>().ToTable("Property");
            modelBuilder.Entity<PropertyInfo>().ToTable("PropertyInfo");
            modelBuilder.Entity<PropertyTaxYear>().ToTable("PropertyTaxYear");
            modelBuilder.Entity<PropertyTransactions>().ToTable("PropertyTransactions");
            modelBuilder.Entity<Tenant>().ToTable("Tenant");
            modelBuilder.Entity<TenantProperties>().ToTable("TenantProperties");
        }
    }
}
