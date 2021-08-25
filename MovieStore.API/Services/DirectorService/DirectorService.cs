using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using MovieStore.API.Dtos;
using MovieStore.API.Dtos.Request.DirectorRequest;
using MovieStore.API.Models;
using MovieStore.API.Repository.DirectorRepository;

namespace MovieStore.API.Services.DirectorService
{
    public class DirectorService : IDirectorService
    {
        private readonly IDirectorRepository _directorRepository;
        private readonly IMapper _mapper;

        public DirectorService(IDirectorRepository directorRepository, IMapper mapper)
        {
            _directorRepository = directorRepository;
            _mapper = mapper;
        }

        public async Task Add(CreateDirectorRequest request)
        {
            await _directorRepository.Add(_mapper.Map<Director>(request));
        }

        public async Task Delete(Guid id)
        {
            await _directorRepository.Delete(id);
        }

        public async Task<DirectorDto> Get(Guid id)
        {
            return _mapper.Map<DirectorDto>(await _directorRepository.Get(id));
        }

        public async Task<IEnumerable<DirectorDto>> GetAll()
        {
            return _mapper.Map<IEnumerable<DirectorDto>>(await _directorRepository.GetAll());
        }

        public IEnumerable<FilmsOfDirectorsDto> GetAllFilms(Guid directorId)
        {
            return _mapper.Map<IEnumerable<FilmsOfDirectorsDto>>(_directorRepository.GetAllFilms(directorId));
        }

        public async Task Update(Guid id, UpdateDirectorRequest request)
        {
            await _directorRepository.Update(id,_mapper.Map<Director>(request));
        }
    }
}