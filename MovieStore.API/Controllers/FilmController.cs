using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using MovieStore.API.Dtos;
using MovieStore.API.Dtos.Request.FilmRequest;
using MovieStore.API.Models;
using MovieStore.API.Services.FilmService;

namespace MovieStore.API.Controllers
{
    [ApiController]
    [Route("[controller]s")]
    public class FilmController : ControllerBase
    {
        private readonly IFilmService _filmService;
        private readonly IMapper _mapper;
        public FilmController(IFilmService filmService, IMapper mapper)
        {
            _filmService = filmService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FilmDto>>> GetAll(){
            var films = await _filmService.GetAll();
            return Ok(films);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<FilmDto>> Get(Guid id){
            var film = await _filmService.Get(id);
            if(film is null)
                return NotFound();
            return Ok(film);
        }
        [HttpPost]
        public async Task<ActionResult> Create(CreateFilmRequest request){
            try
            {
                CreateFilmRequestValidator validator = new CreateFilmRequestValidator();
                validator.ValidateAndThrow(request);
                await _filmService.Add(request);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id){
            await _filmService.Delete(id);
            return Ok();
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> Update(Guid id, UpdateFilmRequest request){
            try
            {
                UpdateFilmRequestValidator validator = new UpdateFilmRequestValidator();
                validator.ValidateAndThrow(request);
                await _filmService.Update(id,request);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }
        [HttpPost("/Actor")]
        public async Task<ActionResult> AddActor(Guid filmId,Guid actorId){
            await _filmService.AddActor(filmId,actorId);
            return Ok();
        }
        [HttpGet("/Actor")]
        public ActionResult<IEnumerable<ActorsOfFilmsDto>> GetAllActor(Guid filmId){
            
            return Ok(_filmService.GetAllActors(filmId));
        }
        [HttpPost("/Director")]
        public async Task<ActionResult> AddDirector(Guid filmId,Guid directorId){
            await _filmService.AddDirector(filmId,directorId);
            return Ok();
        }
        [HttpGet("/Director")]
        public ActionResult<IEnumerable<DirectorsOfFilmsDto>> GetAllDirectors(Guid filmId){
            
            return Ok(_filmService.GetAllDirectors(filmId));
        }
    }
}