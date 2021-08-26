using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MovieStore.API.Models;

namespace MovieStore.API.Repository.OrderRepository
{
    public interface IOrderRepository
    {
        Task Add(Order order);
        Task<Order> Get(Guid id);
        Task<IEnumerable<Order>> GetAll();
        IEnumerable<Order> GetAllByFilmId(Guid id);
        IEnumerable<Order> GetAllByCustomerId(Guid id);
    }
}