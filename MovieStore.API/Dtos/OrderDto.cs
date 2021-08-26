using System;

namespace MovieStore.API.Dtos
{
    public class OrderDto
    {
        public string CustomerName { get; set; }
        public string FilmName { get; set; }

        public double Price { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}