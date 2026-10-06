using SysDesk.Application.DTOs.Tickets;
using SysDesk.Domain.Entities;

namespace SysDesk.Application.Mappings;

public static class TicketMappings
{
    public static TicketDto ToDto(this Ticket entity)
    {
        return new TicketDto
        {
            Id = entity.Id,
            TicketNumber = entity.TicketNumber,
            Title = entity.Title,
            Description = entity.Description,
            StatusId = entity.StatusId,
            PriorityId = entity.PriorityId,
            TicketTypeId = entity.TicketTypeId,
            CreatedAt = entity.CreatedAt
        };
    }
}
