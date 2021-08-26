using System;

namespace MovieStore.API.Dtos
{
    public class CustomersOfOrders
    {
        public string CustomerName { get; set; }
        public string FilmName { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}