namespace SysDesk.Domain.Entities;

public class TicketTag
{
    public Guid TicketId { get; set; }
    public int TagId { get; set; }
    public DateTime CreatedAt { get; set; }

    public Ticket Ticket { get; set; } = null!;
    public Tag Tag { get; set; } = null!;
}
