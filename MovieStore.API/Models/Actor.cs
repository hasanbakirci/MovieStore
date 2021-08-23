using System;
using System.Collections.Generic;

namespace MovieStore.API.Models
{
    public class Actor
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public ICollection<FilmActor> Films { get; set; }

    }
}