using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MovieStore.API.Dtos;
using MovieStore.API.Dtos.Request.CustomerRequest;
using MovieStore.API.Services.CustomerService;

namespace MovieStore.API.Controllers
{
    [ApiController]
    [Route("[controller]s")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        private readonly IMapper _mapper;

        public CustomerController(ICustomerService customerService, IMapper mapper)
        {
            _customerService = customerService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerDto>>> GetAll(){
            var customers = await _customerService.GetAll();
            return Ok(customers);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<CustomerDto>> Get(Guid id){
            var customer = await _customerService.Get(id);
            return Ok(customer);
        }
        [HttpPost]
        public async Task<ActionResult> Create(CreateCustomerRequest request){
            await _customerService.Add(request);
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id){
            await _customerService.Delete(id);
            return Ok();
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> Update(Guid id,UpdateCustomerRequest request){
            await _customerService.Update(id,request);
            return Ok();
        }
    }
}