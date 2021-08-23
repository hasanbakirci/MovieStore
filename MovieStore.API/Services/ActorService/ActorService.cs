using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using MovieStore.API.Dtos;
using MovieStore.API.Dtos.Request.ActorRequest;
using MovieStore.API.Dtos.Request.FilmRequest;
using MovieStore.API.Models;
using MovieStore.API.Repository.ActorRepository;

namespace MovieStore.API.Services.ActorService
{
    
    public class ActorService : IActorService
    {
        private readonly IActorRepository _actorRepository;
        private readonly IMapper _mapper;
        public ActorService(IActorRepository actorRepository, IMapper mapper)
        {
            _actorRepository = actorRepository;
            _mapper = mapper;
        }

        public async Task Add(CreateActorRequest request)
        {
            await _actorRepository.Add(_mapper.Map<Actor>(request));
        }

        public async Task Delete(Guid id)
        {
            await _actorRepository.Delete(id);
        }

        public async Task<ActorDto> Get(Guid id)
        {
            return  _mapper.Map<ActorDto>(await _actorRepository.Get(id));
        }

        public async Task<IEnumerable<ActorDto>> GetAll()
        {
            return _mapper.Map<IEnumerable<ActorDto>>(await _actorRepository.GetAll());
        }

        public IEnumerable<ActorsOfFilmsDto> GetAllFilms(Guid actorId)
        {  
            return _mapper.Map<IEnumerable<ActorsOfFilmsDto>>(_actorRepository.GetAllFilms(actorId));
        }

        public async Task Update(Guid id, UpdateActorRequest request)
        {
            await _actorRepository.Update(id,_mapper.Map<Actor>(request));
        }
    }
}