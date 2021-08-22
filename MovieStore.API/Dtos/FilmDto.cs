using System;

namespace MovieStore.API.Dtos
{
    public class FilmDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime PublishDate { get; set; }
        public string Genre { get; set; }
        public double  Price { get; set; }
        
    }
}