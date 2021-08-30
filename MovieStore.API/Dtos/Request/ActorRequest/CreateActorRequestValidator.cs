using FluentValidation;

namespace MovieStore.API.Dtos.Request.ActorRequest
{
    public class CreateActorRequestValidator : AbstractValidator<CreateActorRequest>
    {
        public CreateActorRequestValidator()
        {
            RuleFor(req => req.Name).NotEmpty().MinimumLength(3).MaximumLength(15);
            RuleFor(req => req.Surname).NotEmpty().MinimumLength(3).MaximumLength(15);
        }
    }
}