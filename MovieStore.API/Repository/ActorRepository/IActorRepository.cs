using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MovieStore.API.Models;

namespace MovieStore.API.Repository.ActorRepository
{
    public interface IActorRepository
    {
        Task Add(Actor actor);
        Task<IEnumerable<Actor>> GetAll();
        Task<Actor> Get(Guid id);
        Task Delete(Guid id);
        Task Update(Guid id, Actor actor);
    }
}