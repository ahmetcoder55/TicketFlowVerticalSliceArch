using MediatR;
using TicketFlow.Api.Common;
using TicketFlow.Api.Database;

namespace TicketFlow.Api.Features.Events
{
    public class CreateEventCommandHandler : IRequestHandler<CreateEventCommand, Result<int>>
    {
        private readonly AppDbContext _context;

        public CreateEventCommandHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Result<int>> Handle(CreateEventCommand request, CancellationToken cancellationToken)
        {
            var eventItem = new Event
            {
                Title = request.CreateEventRequestDto.Title,
                Price = request.CreateEventRequestDto.Price,
                AvailableStock = request.CreateEventRequestDto.InitialStock
            };
            _context.Events.Add(eventItem);

            await _context.SaveChangesAsync(cancellationToken);

            return Result.Success(eventItem.Id);

        }
    }

}
