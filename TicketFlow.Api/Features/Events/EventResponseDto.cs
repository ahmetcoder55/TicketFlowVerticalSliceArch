namespace TicketFlow.Api.Features.Events
{
    // Okuma / Listeleme (Response)
    public record EventResponseDto(
    int Id, 
    string Title, 
    decimal Price, 
    int AvailableStock
);
}
