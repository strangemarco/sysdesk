namespace SysDesk.Domain.Entities;

public class Tag
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public bool IsActive { get; set; }
    public DateTime CreatedAt { get; set; }

    public ICollection<TicketTag> TicketTags { get; set; } = new List<TicketTag>();
}
