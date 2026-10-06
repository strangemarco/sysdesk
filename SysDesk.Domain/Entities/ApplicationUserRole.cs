namespace SysDesk.Domain.Entities;

public class ApplicationUserRole
{
    public Guid ApplicationId { get; set; }
    public Guid UserId { get; set; }
    public short RoleId { get; set; }
    public DateTime CreatedAt { get; set; }

    public Application Application { get; set; } = null!;
    public User User { get; set; } = null!;
    public Role Role { get; set; } = null!;
}
