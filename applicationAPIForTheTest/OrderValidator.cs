using AutoMapper;
using FluentValidation;

namespace applicationAPIForTheTest
{
    public class OrderValidator : AbstractValidator<Order>
    {
        public OrderValidator(IMapper mapper)
        {
            RuleFor(x => x.Items)
                .Must(HaveValidQuantities)
                .WithMessage("Invalid quantities.");

            RuleForEach(x => x.Items)
                .SetValidator(new OrderItemValidator());
        }

        private bool HaveValidQuantities(List<OrderItem> items)
        {
            foreach (var item in items)
            {
                if (item.Quantity <= 0)
                    return false;
            }
            return true;
        }
    }
}
