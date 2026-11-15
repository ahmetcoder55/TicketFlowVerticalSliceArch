namespace TicketFlow.Api.Features.Events
{
    // Oluşturma (Create)
    public record CreateEventRequestDto(
    string Title, 
    decimal Price, 
    int InitialStock
);
}
