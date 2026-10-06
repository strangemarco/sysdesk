namespace SysDesk.Domain.Entities;

public class TicketPriority
{
    public short Id { get; set; }
    public string Code { get; set; } = null!;
    public string Name { get; set; } = null!;
    public short SortOrder { get; set; }
    public bool IsActive { get; set; }
}
