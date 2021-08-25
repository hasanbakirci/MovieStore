using AutoMapper;
using MovieStore.API.Dtos.Request.ActorRequest;
using MovieStore.API.Dtos.Request.DirectorRequest;
using MovieStore.API.Dtos.Request.FilmRequest;
using MovieStore.API.Models;

namespace MovieStore.API.Dtos.Mapper
{
    public class MappingProfile :Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateFilmRequest, Film>();
            CreateMap<Film, FilmDto>().ForMember(dest => dest.Genre, opt => opt.MapFrom(src => ((GenreEnum)src.GenreId).ToString()));

            CreateMap<CreateActorRequest, Actor>();
            CreateMap<Actor,ActorDto>();

            CreateMap<Film,FilmsOfActorsDto>();
            CreateMap<Actor,ActorsOfFilmsDto>();

            CreateMap<CreateDirectorRequest,Director>();
            CreateMap<Director,DirectorDto>();

            CreateMap<Film,FilmsOfDirectorsDto>();
            CreateMap<Director,DirectorsOfFilmsDto>();
        }
        
    }
}