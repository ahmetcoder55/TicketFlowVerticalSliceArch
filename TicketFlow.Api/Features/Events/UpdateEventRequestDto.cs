namespace TicketFlow.Api.Features.Events
{
    // Güncelleme (Update)
    public record UpdateEventRequestDto(
    int Id,
    string Title, 
    decimal Price, 
    int AvailableStock
);
}
