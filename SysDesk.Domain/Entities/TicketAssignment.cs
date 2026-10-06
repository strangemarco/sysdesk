namespace SysDesk.Domain.Entities;

public class TicketAssignment
{
    public Guid Id { get; set; }
    public Guid TicketId { get; set; }
    public Guid AssignedToUserId { get; set; }
    public Guid? AssignedByUserId { get; set; }
    public DateTime AssignedAt { get; set; }
    public DateTime? UnassignedAt { get; set; }
    public bool IsCurrent { get; set; }

    public Ticket Ticket { get; set; } = null!;
    public User AssignedToUser { get; set; } = null!;
    public User? AssignedByUser { get; set; }
}
