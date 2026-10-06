namespace SysDesk.Domain.Entities;

public class Ticket
{
    public Guid Id { get; set; }
    public long TicketNumber { get; set; }
    public Guid ApplicationId { get; set; }
    public Guid? ApplicationModuleId { get; set; }
    public int? CategoryId { get; set; }
    public short TicketTypeId { get; set; }
    public short PriorityId { get; set; }
    public short StatusId { get; set; }
    public short SourceId { get; set; }
    public Guid? RequestedByPersonId { get; set; }
    public Guid? CreatedByUserId { get; set; }
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string? SourceUrl { get; set; }
    public string? ExternalEntityType { get; set; }
    public string? ExternalEntityId { get; set; }
    public DateTime? DueAt { get; set; }
    public DateTime? ResolvedAt { get; set; }
    public DateTime? ClosedAt { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime? DeletedAt { get; set; }
    public Guid? DeletedByUserId { get; set; }

    // Navigation properties
    public Application Application { get; set; } = null!;
    public Person? RequestedByPerson { get; set; }
    public User? CreatedByUser { get; set; }
    public User? DeletedByUser { get; set; }
}
