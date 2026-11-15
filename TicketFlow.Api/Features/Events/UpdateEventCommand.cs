using MediatR;
using TicketFlow.Api.Common;

namespace TicketFlow.Api.Features.Events
{
    public record UpdateEventCommand(int Id, string Title, decimal Price, int AvailableStock) : IRequest<Result>;
}
