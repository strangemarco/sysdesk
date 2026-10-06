namespace SysDesk.Domain.Entities;

public class TicketHistory
{
    public long Id { get; set; }
    public Guid TicketId { get; set; }
    public Guid? UserId { get; set; }
    public string EventType { get; set; } = null!;
    public string? FieldName { get; set; }
    public string? OldValue { get; set; }
    public string? NewValue { get; set; }
    public string? OldReferenceId { get; set; }
    public string? NewReferenceId { get; set; }
    public DateTime CreatedAt { get; set; }

    public Ticket Ticket { get; set; } = null!;
    public User? User { get; set; }
}
