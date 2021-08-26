using System;
using System.Collections.Generic;

namespace MovieStore.API.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public DateTime PurchaseDate { get; set; }
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
        public Guid FilmId { get; set; }
        public Film Film { get; set; }
    }
}