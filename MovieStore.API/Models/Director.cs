using System;
using System.Collections.Generic;

namespace MovieStore.API.Models
{
    public class Director
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public ICollection<FilmDirector> Films { get; set; }
    }
}