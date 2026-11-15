using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TicketFlow.Api.Common;
using TicketFlow.Api.Database;

namespace TicketFlow.Api.Features.Events
{
    public class GetAllEventsQueryHandler : IRequestHandler<GetAllEventsQuery, Result<List<EventResponseDto>>>
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public GetAllEventsQueryHandler(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Result<List<EventResponseDto>>> Handle(GetAllEventsQuery request, CancellationToken cancellationToken)
        {
            var events=await _context.Events.AsNoTracking().ToListAsync(cancellationToken);
            if(events is null)
            {
                Result.Failure("Not Found! Please you create one data");
            }
            var returnDtos=_mapper.Map<List<EventResponseDto>>(events);

            return Result.Success(returnDtos);
        }
    }
}
