using Microsoft.EntityFrameworkCore;
using TicketFlow.Api.Features.Events;

namespace TicketFlow.Api.Database
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContextOptions):base(dbContextOptions)
        {
            
        }
        public DbSet<Event> Events   { get; set; }
    }
}
