using Microsoft.AspNetCore.Mvc;
using SysDesk.Application.DTOs.Tickets;
using SysDesk.Application.Interfaces;

namespace SysDesk.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TicketsController : ControllerBase
{
    private readonly ITicketService _ticketService;

    public TicketsController(ITicketService ticketService)
    {
        _ticketService = ticketService;
    }

    [HttpGet("{id:guid}")]
    public async Task<ActionResult<TicketDto>> GetTicketById(Guid id, CancellationToken cancellationToken)
    {
        var ticket = await _ticketService.GetTicketByIdAsync(id, cancellationToken);
        if (ticket == null)
            return NotFound();

        return Ok(ticket);
    }

    [HttpPost]
    public async Task<ActionResult<TicketDto>> CreateTicket([FromBody] CreateTicketDto dto, CancellationToken cancellationToken)
    {
        var createdTicket = await _ticketService.CreateTicketAsync(dto, cancellationToken);
        
        return CreatedAtAction(nameof(GetTicketById), new { id = createdTicket.Id }, createdTicket);
    }
}
