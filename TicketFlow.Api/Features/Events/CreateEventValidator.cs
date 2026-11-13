using FluentValidation;

namespace TicketFlow.Api.Features.Events
{
    public class CreateEventValidator:AbstractValidator<Event>
    {
        public CreateEventValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Etkinlik adı boş olamaz!").MaximumLength(150);
            RuleFor(x => x.Price).GreaterThan(0).WithMessage("Fiyat 0'dan büyük olmalıdır!");
            RuleFor(x => x.AvailableStock).GreaterThan(0).WithMessage("Stok 0'dan büyük olmalıdır!");
        }
    }
}
