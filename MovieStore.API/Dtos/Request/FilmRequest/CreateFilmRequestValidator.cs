using FluentValidation;

namespace MovieStore.API.Dtos.Request.FilmRequest
{
    public class CreateFilmRequestValidator : AbstractValidator<CreateFilmRequest>
    {
        public CreateFilmRequestValidator()
        {
            RuleFor(req => req.Name).NotEmpty().MinimumLength(3).MaximumLength(15);
            RuleFor(req => req.GenreId).NotEmpty().GreaterThan(0);
            RuleFor(req => req.Price).NotEmpty().GreaterThan(0);
        }
    }
}