using MediatR;
using TicketFlow.Api.Common;

namespace TicketFlow.Api.Features.Events
{
    public record CreateEventCommand(CreateEventRequestDto CreateEventRequestDto) : IRequest<Result<int>>;
}
