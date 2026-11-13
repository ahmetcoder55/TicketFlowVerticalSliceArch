using System.ComponentModel.DataAnnotations;

namespace TicketFlow.Api.Features.Events
{
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int AvailableStock { get; set; }

        [ConcurrencyCheck] 
        public int Version { get; set; }
    }
}
