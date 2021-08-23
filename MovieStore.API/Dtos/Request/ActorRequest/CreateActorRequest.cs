using System.Collections.Generic;
using MovieStore.API.Models;

namespace MovieStore.API.Dtos.Request.ActorRequest
{
    public class CreateActorRequest
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}