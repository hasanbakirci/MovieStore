using System;
using System.Collections.Generic;

namespace MovieStore.API.Dtos
{
    public class ActorDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}