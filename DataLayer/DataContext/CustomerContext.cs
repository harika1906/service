using DataLayer.CustomerDetails;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.DataContext
{
   public class CustomerContext : DbContext , ICustomerContext
    {
        public CustomerContext(DbContextOptions options) :base(options)
        {

        }

        public DbSet<Customer> customers { get; set; }
        public DbSet<CustomerAddress> customeraddress { get; set; }
        public DbSet<CustomerContact> customerContact { get; set; }      
    }
    public interface ICustomerContext
    {
        DbSet<Customer> customers { get; set; }
        DbSet<CustomerAddress> customeraddress { get; set; }
        DbSet<CustomerContact> customerContact { get; set; }
    }
}
