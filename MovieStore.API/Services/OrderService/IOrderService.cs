using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MovieStore.API.Dtos;
using MovieStore.API.Dtos.Request.OrderRequest;

namespace MovieStore.API.Services.OrderService
{
    public interface IOrderService
    {
        Task Add(CreateOrderRequest request);
        Task<OrderDto> Get(Guid id);
        Task<IEnumerable<OrderDto>> GetAll();
        IEnumerable<OrderDto> GetAllByFilmId(Guid id);
        IEnumerable<OrderDto> GetAllByCustomerId(Guid id);
    }
}