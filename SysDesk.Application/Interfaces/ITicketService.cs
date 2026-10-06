using SysDesk.Application.DTOs.Tickets;

namespace SysDesk.Application.Interfaces;

public interface ITicketService
{
    Task<TicketDto?> GetTicketByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<TicketDto> CreateTicketAsync(CreateTicketDto dto, CancellationToken cancellationToken = default);
}
