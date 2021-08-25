using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MovieStore.API.Dtos;
using MovieStore.API.Dtos.Request.ActorRequest;


namespace MovieStore.API.Services.ActorService
{
    public interface IActorService
    {
        Task Add(CreateActorRequest request);
        Task<IEnumerable<ActorDto>> GetAll();
        Task<ActorDto> Get(Guid id);
        Task Delete(Guid id);
        Task Update(Guid id, UpdateActorRequest request);
        IEnumerable<FilmsOfActorsDto> GetAllFilms(Guid actorId);
    }
}