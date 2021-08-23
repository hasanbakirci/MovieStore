using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using MovieStore.API.Dtos;
using MovieStore.API.Dtos.Request.FilmRequest;
using MovieStore.API.Models;
using MovieStore.API.Repository.FilmRepository;

namespace MovieStore.API.Services.FilmService
{
    public class FilmService : IFilmService
    {
        private readonly IFilmRepository _filmRepository;
        private readonly IMapper _mapper;

        public FilmService(IFilmRepository filmRepository, IMapper mapper)
        {
            _filmRepository = filmRepository;
            _mapper = mapper;
        }

        public async Task Add(CreateFilmRequest request)
        {
            await _filmRepository.Add(_mapper.Map<Film>(request));
        }

        public async Task AddActor(Guid filmId, Guid actorId)
        {
            await _filmRepository.AddActor(filmId,actorId);
        }

        public async Task Delete(Guid id)
        {
            await _filmRepository.Delete(id);
        }

        public async Task<FilmDto> Get(Guid id)
        {
            return  _mapper.Map<FilmDto>(await _filmRepository.Get(id));
        }

        public async Task<IEnumerable<FilmDto>> GetAll()
        {
            return _mapper.Map<IEnumerable<FilmDto>>(await _filmRepository.GetAll());
        }

        public IEnumerable<FilmsOfActorsDto> GetAllActors(Guid filmId)
        {
            return _mapper.Map<IEnumerable<FilmsOfActorsDto>>(_filmRepository.GetAllActors(filmId));
        }

        public async Task Update(Guid id, UpdateFilmRequest request)
        {
            await _filmRepository.Update(id,_mapper.Map<Film>(request));
        }
    }
}