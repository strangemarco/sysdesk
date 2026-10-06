namespace SysDesk.Domain.Entities;

public class User
{
    public Guid Id { get; set; }
    public Guid? PersonId { get; set; }
    public string IdentityProvider { get; set; } = null!;
    public string ExternalId { get; set; } = null!;
    public string? Username { get; set; }
    public bool IsActive { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }

    // Navigation properties
    public Person? Person { get; set; }
}
