using AutoMapper;
using MovieStore.API.Dtos.Request.ActorRequest;
using MovieStore.API.Dtos.Request.CustomerRequest;
using MovieStore.API.Dtos.Request.DirectorRequest;
using MovieStore.API.Dtos.Request.FilmRequest;
using MovieStore.API.Dtos.Request.OrderRequest;
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

            CreateMap<Customer,CustomerDto>();
            CreateMap<CreateCustomerRequest,Customer>();

            CreateMap<Order,OrderDto>()
            .ForMember(dest => dest.CustomerName, opt => opt.MapFrom(src => src.Customer.Name))
            .ForMember(dest => dest.FilmName, opt => opt.MapFrom(src => src.Film.Name))
            .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Film.Price))
            .ForMember(dest => dest.PurchaseDate, opt => opt.MapFrom(src => src.Film.PublishDate));
            CreateMap<CreateOrderRequest,Order>();

        }
        
    }
}