using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieStore.API.Models;

namespace MovieStore.API.Repository.CustomerRepository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly IMovieStoreDbContext _context;

        public CustomerRepository(IMovieStoreDbContext context)
        {
            _context = context;
        }

        public async Task Add(Customer customer)
        {
            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            var customer = _context.Customers.Find(id);
            if(customer is null)
                throw new InvalidOperationException("Customer bulunamadı");
            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();
        }

        public async Task<Customer> Get(Guid id)
        {
            return await _context.Customers.FindAsync(id);
        }

        public async Task<IEnumerable<Customer>> GetAll()
        {
            return await _context.Customers.ToListAsync();
        }

        public async Task Update(Guid id, Customer customer)
        {
            var result = _context.Customers.Find(id);
            if(result is null)
                throw new InvalidOperationException("Customer bulunamadı");
            result.Email = customer.Email != default ? customer.Email : result.Email;
            await _context.SaveChangesAsync();
        }
    }
}