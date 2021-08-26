using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using MovieStore.API.Dtos;
using MovieStore.API.Dtos.Request.OrderRequest;
using MovieStore.API.Models;
using MovieStore.API.Repository.OrderRepository;
using MovieStore.API.Services.CustomerService;
using MovieStore.API.Services.FilmService;

namespace MovieStore.API.Services.OrderService
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;

        public OrderService(IOrderRepository orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;

            _mapper = mapper;
        }

        public async Task Add(CreateOrderRequest request)
        {
            await _orderRepository.Add(_mapper.Map<Order>(request));
        }

        public async Task<OrderDto> Get(Guid id)
        {
            return _mapper.Map<OrderDto>(await _orderRepository.Get(id));
        }

        public async Task<IEnumerable<OrderDto>> GetAll()
        {
            return _mapper.Map<IEnumerable<OrderDto>>(await _orderRepository.GetAll());
        }

        public IEnumerable<OrderDto> GetAllByCustomerId(Guid id)
        {
            return _mapper.Map<IEnumerable<OrderDto>>(_orderRepository.GetAllByCustomerId(id));
        }

        public IEnumerable<OrderDto> GetAllByFilmId(Guid id)
        {
            return _mapper.Map<IEnumerable<OrderDto>>(_orderRepository.GetAllByFilmId(id));
        }
    }
}