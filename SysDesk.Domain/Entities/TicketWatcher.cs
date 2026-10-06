namespace SysDesk.Domain.Entities;

public class TicketWatcher
{
    public Guid TicketId { get; set; }
    public Guid UserId { get; set; }
    public Guid? CreatedByUserId { get; set; }
    public DateTime CreatedAt { get; set; }

    public Ticket Ticket { get; set; } = null!;
    public User User { get; set; } = null!;
    public User? CreatedByUser { get; set; }
}
