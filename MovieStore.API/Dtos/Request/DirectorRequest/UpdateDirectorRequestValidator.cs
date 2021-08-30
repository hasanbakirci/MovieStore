using FluentValidation;

namespace MovieStore.API.Dtos.Request.DirectorRequest
{
    public class UpdateDirectorRequestValidator : AbstractValidator<UpdateDirectorRequest>
    {
        public UpdateDirectorRequestValidator()
        {
            RuleFor(req => req.Name).NotEmpty().MinimumLength(3).MaximumLength(15);
            RuleFor(req => req.Surname).NotEmpty().MinimumLength(3).MaximumLength(15);
        }
    }
}