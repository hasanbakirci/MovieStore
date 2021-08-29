using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieStore.API.Models;

namespace MovieStore.API.Repository.OrderRepository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly IMovieStoreDbContext _context;

        public OrderRepository(IMovieStoreDbContext context)
        {
            _context = context;
        }

        public async Task Add(Order order)
        {
            var customer = _context.Customers.Find(order.CustomerId);
            var film = _context.Films.Find(order.FilmId);
            if(customer is null || film is null)
                throw new InvalidOperationException("Hatalı giriş");
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
        }

        public async Task<Order> Get(Guid id)
        {
            return await _context.Orders.FindAsync(id);
        }

        public async Task<IEnumerable<Order>> GetAll()
        {
            return await _context.Orders.ToListAsync();
        }

        public IEnumerable<Order> GetAllByFilmId(Guid id)
        {
            var film = _context.Films.Find(id);
            if(film is null)
                throw new InvalidOperationException("Film bulunamadı");
            return _context.Orders.Include(i => i.Customer).Include(i => i.Film).Where(item => item.FilmId == id);

        }

        public IEnumerable<Order> GetAllByCustomerId(Guid id)
        {
            var customer = _context.Customers.Find(id);
            if(customer is null)
                throw new InvalidOperationException("Customer bulunamadı");
            return _context.Orders.Include(i => i.Customer).Include(i => i.Film).Where(item => item.CustomerId == id);
        }
    }
}