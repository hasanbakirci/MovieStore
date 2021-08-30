using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using MovieStore.API.Dtos;
using MovieStore.API.Dtos.Request.OrderRequest;
using MovieStore.API.Services.OrderService;

namespace MovieStore.API.Controllers
{
    [ApiController]
    [Route("[controller]s")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly IMapper _mapper;

        public OrderController(IOrderService orderService, IMapper mapper)
        {
            _orderService = orderService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderDto>>> GetAll(){
            var orders = await _orderService.GetAll();
            return Ok(orders);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<OrderDto>> Get(Guid id){
            var order = await _orderService.Get(id);
            return Ok(order);
        }
        [HttpPost]
        public async Task<ActionResult> Create(CreateOrderRequest request){
            try
            {
                CreateOrderRequestValidator validator = new CreateOrderRequestValidator();
                validator.ValidateAndThrow(request);
                await _orderService.Add(request);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }
        [HttpGet("/Film/{id}")]
        public ActionResult<IEnumerable<OrderDto>> GetAllByFilmId(Guid id){
            var orders = _orderService.GetAllByFilmId(id);
            return Ok(orders);
        }
        [HttpGet("/Customer/{id}")]
        public ActionResult<IEnumerable<OrderDto>> GetAllByCustomerId(Guid id){
            var orders = _orderService.GetAllByCustomerId(id);
            return Ok(orders);
        }
    }
}