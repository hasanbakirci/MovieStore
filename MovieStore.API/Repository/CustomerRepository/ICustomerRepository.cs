using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MovieStore.API.Models;

namespace MovieStore.API.Repository.CustomerRepository
{
    public interface ICustomerRepository
    {
        Task Add(Customer customer);
        Task<Customer> Get(Guid id);
        Task<IEnumerable<Customer>> GetAll();
        Task Delete(Guid id);
        Task Update(Guid id, Customer customer);
    }
}