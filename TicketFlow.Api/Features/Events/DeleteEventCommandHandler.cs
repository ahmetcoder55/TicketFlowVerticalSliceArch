using MediatR;
using Microsoft.EntityFrameworkCore;
using TicketFlow.Api.Common;
using TicketFlow.Api.Database;

namespace TicketFlow.Api.Features.Events
{
    public class DeleteEventCommandHandler : IRequestHandler<DeleteEventCommand, Result>
    {
        private readonly AppDbContext _context;

        public DeleteEventCommandHandler(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Result> Handle(DeleteEventCommand request, CancellationToken cancellationToken)
    {
        var eventItem = await _context.Events.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);

        if (eventItem is null)
            return Result.Failure($"Silinecek etkinlik bulunamadı (ID: {request.Id}).");

        _context.Events.Remove(eventItem);
        await _context.SaveChangesAsync(cancellationToken);

        return Result.Success();
    }
    }

}
