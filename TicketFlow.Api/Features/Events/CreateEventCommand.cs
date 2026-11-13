using MediatR;
using TicketFlow.Api.Common;

namespace TicketFlow.Api.Features.Events
{
    public record CreateEventCommand(string Title, decimal Price, int InitialStock) : IRequest<Result<int>>;
}
