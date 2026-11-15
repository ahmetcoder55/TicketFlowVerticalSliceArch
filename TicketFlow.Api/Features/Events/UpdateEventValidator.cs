using FluentValidation;

namespace TicketFlow.Api.Features.Events
{
    public class UpdateEventValidator : AbstractValidator<UpdateEventCommand>
{
    public UpdateEventValidator()
    {
        RuleFor(x => x.Id).GreaterThan(0);
        RuleFor(x => x.Title).NotEmpty().MaximumLength(150);
        RuleFor(x => x.Price).GreaterThan(0);
        RuleFor(x => x.AvailableStock).GreaterThanOrEqualTo(0);
    }
}
}
