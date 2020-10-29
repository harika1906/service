using DataLayer.CustomerDetails;
using DataLayer.DataContext;
using System;
using System.Linq;

namespace DataLayer
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ICustomerContext _customercontext;
        public CustomerRepository(CustomerContext customercontext)
        {
            _customercontext = customercontext;
        }
        public Customer GetCustomer(int id)
        {
           var customer= _customercontext.customers.FirstOrDefault(x => x.CustomerId == id);
            return customer;
        }
    }

    public interface ICustomerRepository
    {
        Customer GetCustomer(int id);
    }
}
