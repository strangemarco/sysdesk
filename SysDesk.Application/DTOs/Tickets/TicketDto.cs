namespace SysDesk.Application.DTOs.Tickets;

public class TicketDto
{
    public Guid Id { get; set; }
    public long TicketNumber { get; set; }
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public short StatusId { get; set; }
    public short PriorityId { get; set; }
    public short TicketTypeId { get; set; }
    public DateTime CreatedAt { get; set; }
}
