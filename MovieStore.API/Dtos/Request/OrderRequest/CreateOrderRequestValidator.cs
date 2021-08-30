using FluentValidation;

namespace MovieStore.API.Dtos.Request.OrderRequest
{
    public class CreateOrderRequestValidator : AbstractValidator<CreateOrderRequest>
    {
        public CreateOrderRequestValidator()
        {
            RuleFor(req => req.CustomerId).NotEmpty();
            RuleFor(req => req.FilmId).NotEmpty();
        }
    }
}