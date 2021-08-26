using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using MovieStore.API.Dtos;
using MovieStore.API.Dtos.Request.CustomerRequest;
using MovieStore.API.Models;
using MovieStore.API.Repository.CustomerRepository;

namespace MovieStore.API.Services.CustomerService
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public CustomerService(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        public async Task Add(CreateCustomerRequest request)
        {
            await _customerRepository.Add(_mapper.Map<Customer>(request));
        }

        public async Task Delete(Guid id)
        {
            await _customerRepository.Delete(id);
        }

        public async Task<CustomerDto> Get(Guid id)
        {
            return _mapper.Map<CustomerDto>(await _customerRepository.Get(id));
        }

        public async Task<IEnumerable<CustomerDto>> GetAll()
        {
            return _mapper.Map<IEnumerable<CustomerDto>>(await _customerRepository.GetAll());
        }

        public async Task Update(Guid id, UpdateCustomerRequest request)
        {
            await _customerRepository.Update(id,_mapper.Map<Customer>(request));
        }
    }
}