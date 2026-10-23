using Layered_Architecture.EntityLayer.Concrete;
using System.Data.Entity;

namespace Layered_Architecture.DataAccessLayer.Context
{
    public class ExampleContext:DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Admin> Admins { get; set; }



    }
}
