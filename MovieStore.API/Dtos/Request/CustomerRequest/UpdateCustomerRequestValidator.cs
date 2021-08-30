using FluentValidation;

namespace MovieStore.API.Dtos.Request.CustomerRequest
{
    public class UpdateCustomerRequestValidator : AbstractValidator<UpdateCustomerRequest>
    {
        public UpdateCustomerRequestValidator()
        {
            RuleFor(req => req.Email).NotEmpty().EmailAddress();
        }
    }
}