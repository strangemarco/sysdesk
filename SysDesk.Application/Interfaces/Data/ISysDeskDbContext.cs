using Microsoft.EntityFrameworkCore;
using SysDesk.Domain.Entities;

namespace SysDesk.Application.Interfaces.Data;

public interface ISysDeskDbContext
{
    DbSet<Ticket> Tickets { get; }
    DbSet<TicketStatus> TicketStatuses { get; }
    
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
