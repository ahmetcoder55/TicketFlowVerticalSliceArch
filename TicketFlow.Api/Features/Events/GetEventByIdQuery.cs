using MediatR;
using TicketFlow.Api.Common;

namespace TicketFlow.Api.Features.Events
{
    public record GetEventByIdQuery(int id):IRequest<Result<EventResponseDto>>;
}