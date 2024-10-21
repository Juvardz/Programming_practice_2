using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedProgramming_Week3.Repository.Repository
{
    public class CustomerRepository : RepositoryBase<Customer>
    {

        public IEnumerable<Customer> GetAllCustomer()
        {
            return GetEntities();
        }

        public Customer GetCustomerByID(int pID)
        {
            return GetByID(pID);
        }

        public Customer GetCustomerByName(string pName)
        {
            return GetByName(pName);
        }

        public bool CreateCustomer(Customer customer)
        {
            ProductDBEntities.Customer.Add(customer);
            return ProductDBEntities.SaveChanges() > 0;
        }

        public bool UpdateCustomer(Customer customer)
        {
            return Update(customer);
        }

        public bool DeleteCustomer(Customer customer)
        {
            ProductDBEntities.Customer.Remove(customer);
            return ProductDBEntities.SaveChanges() > 0;
        }               
    }
}
