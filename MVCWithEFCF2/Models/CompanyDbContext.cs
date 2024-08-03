using System.Data.Entity;
namespace MVCWithEFCF2.Models
{
    public class CompanyDbContext : DbContext
    {
        public CompanyDbContext() : base("ConStr")
        {
            Database.SetInitializer (new CompanyDBInitializer());
        }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}