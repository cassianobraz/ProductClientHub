using FluentValidation;
using ProductClientHub.Communication.Requests;

namespace ProductClientHub.API.UseCases.Products.SharedValidator;

public class RequestProductValidator : AbstractValidator<RequestProductJson>
{
    public RequestProductValidator()
    {
        RuleFor(product => product.Name).NotEmpty().WithMessage("Product name invalid.");
        RuleFor(product => product.Brand).NotEmpty().WithMessage("Brand in product invalid.");
        RuleFor(product => product.Price).GreaterThan(0).WithMessage("Price for product invalid.");
    }
}
