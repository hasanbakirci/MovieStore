using FluentValidation;

namespace MovieStore.API.Dtos.Request.CustomerRequest
{
    public class CreateCustomerRequestValidator : AbstractValidator<CreateCustomerRequest>
    {
        public CreateCustomerRequestValidator()
        {
            RuleFor(req => req.Name).NotEmpty().MinimumLength(3).MaximumLength(15);
            RuleFor(req => req.Surname).NotEmpty().MinimumLength(3).MaximumLength(15);
            RuleFor(req => req.Email).NotEmpty().EmailAddress();
            RuleFor(req => req.Password).NotEmpty().MinimumLength(3).MaximumLength(15);
        }
    }
}