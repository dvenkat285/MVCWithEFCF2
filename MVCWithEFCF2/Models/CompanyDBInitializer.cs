using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCWithEFCF2.Models
{
    public class CompanyDBInitializer : DropCreateDatabaseAlways<CompanyDbContext>
    {
        protected override void Seed(CompanyDbContext context)
        {
            Supplier s1 = new Supplier { Sid = 101, SupplierName = "Ashok Distributors." };
            Supplier s2 = new Supplier { Sid = 102, SupplierName = "Meghna Distributors." };
            Supplier s3 = new Supplier { Sid = 103, SupplierName = "Diamond Distributors." };
            Supplier s4 = new Supplier { Sid = 104, SupplierName = "Prasad Distributors." };
            Supplier s5 = new Supplier { Sid = 105, SupplierName = "Star Distributors." };

            context.Suppliers.Add(s1);
            context.Suppliers.Add(s2);
            context.Suppliers.Add(s3); 
            context.Suppliers.Add(s4);
            context.Suppliers.Add(s5);
            context.SaveChanges();
        }
    }
}