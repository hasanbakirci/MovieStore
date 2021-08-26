using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MovieStore.API.Dtos;
using MovieStore.API.Dtos.Request.CustomerRequest;

namespace MovieStore.API.Services.CustomerService
{
    public interface ICustomerService
    {
        Task Add(CreateCustomerRequest request);
        Task<CustomerDto> Get(Guid id);
        Task<IEnumerable<CustomerDto>> GetAll();
        Task Delete(Guid id);
        Task Update(Guid id, UpdateCustomerRequest request);
    }
}