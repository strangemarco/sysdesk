using Microsoft.EntityFrameworkCore;
using SysDesk.Application.DTOs.Tickets;
using SysDesk.Application.Interfaces;
using SysDesk.Application.Interfaces.Data;
using SysDesk.Application.Mappings;
using SysDesk.Domain.Entities;

namespace SysDesk.Application.Services;

public class TicketService : ITicketService
{
    private readonly ISysDeskDbContext _context;

    public TicketService(ISysDeskDbContext context)
    {
        _context = context;
    }

    public async Task<TicketDto?> GetTicketByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        var ticket = await _context.Tickets
            .AsNoTracking()
            .FirstOrDefaultAsync(t => t.Id == id && !t.IsDeleted, cancellationToken);

        return ticket?.ToDto();
    }

    public async Task<TicketDto> CreateTicketAsync(CreateTicketDto dto, CancellationToken cancellationToken = default)
    {
        var ticket = new Ticket
        {
            ApplicationId = dto.ApplicationId,
            TicketTypeId = dto.TicketTypeId,
            PriorityId = dto.PriorityId,
            SourceId = dto.SourceId,
            StatusId = 1, // 1 = NEW (según el catálogo)
            RequestedByPersonId = dto.RequestedByPersonId,
            Title = dto.Title,
            Description = dto.Description,
            CreatedAt = DateTime.UtcNow,
            IsDeleted = false
        };

        _context.Tickets.Add(ticket);
        await _context.SaveChangesAsync(cancellationToken);

        return ticket.ToDto();
    }
}
