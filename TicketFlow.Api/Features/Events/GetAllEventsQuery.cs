using MediatR;
using TicketFlow.Api.Common;

namespace TicketFlow.Api.Features.Events
{
    public record GetAllEventsQuery():IRequest<Result<List<EventResponseDto>>>;
}