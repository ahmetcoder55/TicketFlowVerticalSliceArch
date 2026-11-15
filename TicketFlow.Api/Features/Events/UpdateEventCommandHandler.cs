using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TicketFlow.Api.Common;
using TicketFlow.Api.Database;

namespace TicketFlow.Api.Features.Events
{
    public class UpdateEventCommandHandler : IRequestHandler<UpdateEventCommand, Result>
    {
        private readonly AppDbContext _context;

        public UpdateEventCommandHandler(AppDbContext context)
        {
            _context = context;
        }

    public async Task<Result> Handle(UpdateEventCommand request, CancellationToken cancellationToken)
    {
        var eventItem = await _context.Events.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);

        if (eventItem is null)
            return Result.Failure($"Güncellenecek etkinlik bulunamadı (ID: {request.Id}).");

        eventItem.Title = request.Title;
        eventItem.Price = request.Price;
        eventItem.AvailableStock = request.AvailableStock;
        eventItem.Version++;

        await _context.SaveChangesAsync(cancellationToken);
        return Result.Success();
    }
    }
}