using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TicketFlow.Api.Features.Events
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EventsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost("create-one")]

        public async Task<IActionResult> CreateAsync([FromBody]CreateEventCommand createEventCommand)
        {
            var result = await _mediator.Send(createEventCommand);

            if (result.IsFailure)
            {
                return BadRequest(result.ErrorMessage);
            }

            return Ok(new { EventId = result.Data, Message = "Etkinlik başarıyla oluşturuldu!" });
        }
    }
}
