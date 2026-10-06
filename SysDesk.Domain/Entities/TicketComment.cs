namespace SysDesk.Domain.Entities;

public class TicketComment
{
    public Guid Id { get; set; }
    public Guid TicketId { get; set; }
    public Guid UserId { get; set; }
    public string Comment { get; set; } = null!;
    public bool IsInternal { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime? DeletedAt { get; set; }

    public Ticket Ticket { get; set; } = null!;
    public User User { get; set; } = null!;
    public ICollection<TicketAttachment> Attachments { get; set; } = new List<TicketAttachment>();
}
