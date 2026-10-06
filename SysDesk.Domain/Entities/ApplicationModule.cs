namespace SysDesk.Domain.Entities;

public class ApplicationModule
{
    public Guid Id { get; set; }
    public Guid ApplicationId { get; set; }
    public string Code { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
    public bool IsActive { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    
    public Application Application { get; set; } = null!;
}
