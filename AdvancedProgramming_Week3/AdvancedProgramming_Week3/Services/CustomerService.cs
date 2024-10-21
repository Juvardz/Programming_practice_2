
using AdvancedProgramming_Week3.Repository.Repository;
using AdvancedProgramming_Week3.Repository;
using System.Collections.Generic;


namespace AdvancedProgramming_Week3.Services
{
    public class CustomerService
    {
        private readonly CustomerRepository _repository;

        public CustomerService()
        {
            _repository = new CustomerRepository();
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return _repository.GetAllCustomer();
        }

        public Customer GetCustomerByID(int id)
        {
            return _repository.GetCustomerByID(id);
        }

        public bool CreateCustomer(Customer customer)
        {
            return _repository.CreateCustomer(customer);
        }

        public bool UpdateCustomer(Customer customer)
        {
            return _repository.UpdateCustomer(customer);
        }

        public bool DeleteCustomer(Customer customer)
        {
            return _repository.DeleteCustomer(customer);
        }
    }
}
