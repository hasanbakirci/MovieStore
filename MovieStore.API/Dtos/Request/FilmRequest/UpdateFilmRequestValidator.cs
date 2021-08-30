using FluentValidation;

namespace MovieStore.API.Dtos.Request.FilmRequest
{
    public class UpdateFilmRequestValidator : AbstractValidator<UpdateFilmRequest>
    {
        public UpdateFilmRequestValidator()
        {
            RuleFor(req => req.Name).NotEmpty().MinimumLength(3).MaximumLength(15);
            RuleFor(req => req.GenreId).NotEmpty().GreaterThan(0); 
        }
    }
}