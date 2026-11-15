using AutoMapper;
using TicketFlow.Api.Features.Events;

namespace TicketFlow.Api.Common
{
   public class GeneralMapping:Profile
    {
        public GeneralMapping()
        {
            CreateMap<CreateEventRequestDto, CreateEventCommand>();
        CreateMap<Event, EventResponseDto>();
        }
    }   
}