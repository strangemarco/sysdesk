namespace SysDesk.Domain.Entities;

public class TicketContext
{
    public Guid TicketId { get; set; }
    public string? Route { get; set; }
    public string? Browser { get; set; }
    public string? OperatingSystem { get; set; }
    public string? ClientVersion { get; set; }
    public string? ApiVersion { get; set; }
    public string? CorrelationId { get; set; }
    public string? TraceId { get; set; }
    public string? IpAddress { get; set; }
    public string? AdditionalData { get; set; } // JSON
    public DateTime CreatedAt { get; set; }

    public Ticket Ticket { get; set; } = null!;
}
