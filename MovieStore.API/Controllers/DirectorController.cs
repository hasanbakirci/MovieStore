using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using MovieStore.API.Dtos;
using MovieStore.API.Dtos.Request.DirectorRequest;
using MovieStore.API.Services.DirectorService;

namespace MovieStore.API.Controllers
{
    [ApiController]
    [Route("[controller]s")]
    public class DirectorController : ControllerBase
    {
        private readonly IDirectorService _directorService;
        private readonly IMapper _mapper;

        public DirectorController(IDirectorService directorService, IMapper mapper)
        {
            _directorService = directorService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DirectorDto>>> GetAll(){
            var directors = await _directorService.GetAll();
            return Ok(directors);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<DirectorDto>> Get(Guid id){
            var director = await _directorService.Get(id);
            return Ok(director);
        }
        [HttpPost]
        public async Task<ActionResult> Create(CreateDirectorRequest request){
            try
            {
                CreateDirectorRequestValidator validator = new CreateDirectorRequestValidator();
                validator.ValidateAndThrow(request);
                await _directorService.Add(request);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id){
            await _directorService.Delete(id);
            return Ok();
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> Update(Guid id, UpdateDirectorRequest request){
            try
            {
                UpdateDirectorRequestValidator validator = new UpdateDirectorRequestValidator();
                validator.ValidateAndThrow(request);
                await _directorService.Update(id,request);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }
        [HttpGet("/FilmsOfDirector")]
        public ActionResult<IEnumerable<FilmsOfDirectorsDto>> GetAllFilmsOfDirector(Guid directorId){
            return Ok(_directorService.GetAllFilms(directorId));
        }
    }
}