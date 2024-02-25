using FluentValidation;

namespace applicationAPIForTheTest
{
    public class OrderItemValidator : AbstractValidator<OrderItem>
    {
        public OrderItemValidator()
        {
            RuleFor(x => x.ProductName).NotEmpty().MaximumLength(50);
            RuleFor(x => x.Quantity).GreaterThan(0);
        }
    }
}
