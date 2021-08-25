using System;
using System.Collections.Generic;

namespace MovieStore.API.Models
{
    public class Film
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime PublishDate { get; set; } = DateTime.Now;
        public int GenreId { get; set; }
        public double  Price { get; set; }
        public ICollection<FilmActor> Actors { get; set; }
        public ICollection<FilmDirector> Directors { get; set; }
    
    }
}