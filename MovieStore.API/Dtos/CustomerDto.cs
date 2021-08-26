using System;

namespace MovieStore.API.Dtos
{
    public class CustomerDto
    {
        public Guid Id {get; set;}
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
    }
}