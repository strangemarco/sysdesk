namespace SysDesk.Domain.Entities;

public class TicketStatus
{
    public short Id { get; set; }
    public string Code { get; set; } = null!;
    public string Name { get; set; } = null!;
    public short SortOrder { get; set; }
    public bool IsInitial { get; set; }
    public bool IsResolved { get; set; }
    public bool IsClosed { get; set; }
    public bool IsActive { get; set; }
}
