using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MovieStore.API.Dtos;
using MovieStore.API.Dtos.Request.ActorRequest;
using MovieStore.API.Services.ActorService;

namespace MovieStore.API.Controllers
{
    [ApiController]
    [Route("[controller]s")]
    public class ActorController : ControllerBase
    {
        private readonly IActorService _actorService;
        private readonly IMapper _mapper;

        public ActorController(IActorService actorService,IMapper mapper)
        {
            _actorService = actorService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ActorDto>>> GetAll(){
            var actors = await _actorService.GetAll();
            return Ok(actors);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ActorDto>> Get(Guid id){
            var actor = await _actorService.Get(id);
            if(actor is null)
                return NotFound();
            return Ok(actor);
        }
        [HttpPost]
        public async Task<ActionResult> Create(CreateActorRequest request){
            await _actorService.Add(request);
            return Ok();
        }
        [HttpDelete]
        public async Task<ActionResult> Delete(Guid id){
            await _actorService.Delete(id);
            return Ok();
        }
        [HttpPut("{id}")]
        public async Task<ActionResult> Update(Guid id, UpdateActorRequest request){
            await _actorService.Update(id,request);
            return Ok();
        }
        [HttpGet("/FilmsOfActor")]
        public ActionResult<IEnumerable<FilmsOfActorsDto>> GetAllFilmsOfActor(Guid actorId){
            return Ok(_actorService.GetAllFilms(actorId));
        }
    }
}