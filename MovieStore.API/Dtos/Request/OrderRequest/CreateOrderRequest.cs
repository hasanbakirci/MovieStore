using System;

namespace MovieStore.API.Dtos.Request.OrderRequest
{
    public class CreateOrderRequest
    {
        public Guid CustomerId { get; set; }
        public Guid FilmId { get; set; }
    }
}