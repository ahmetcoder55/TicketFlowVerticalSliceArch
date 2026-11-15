using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TicketFlow.Api.Common;
using TicketFlow.Api.Database;

namespace TicketFlow.Api.Features.Events
{
    public class GetEventByIdQueryHandler : IRequestHandler<GetEventByIdQuery, Result<EventResponseDto>>
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public GetEventByIdQueryHandler(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<Result<EventResponseDto>> Handle(GetEventByIdQuery request, CancellationToken cancellationToken)
        {
            var eventItem=await _context.Events.AsNoTracking()
            .FirstOrDefaultAsync(x=>x.Id==request.id,cancellationToken);

            var returnDtos=_mapper.Map<EventResponseDto>(eventItem);

            return Result.Success(returnDtos);
        }
    }
}