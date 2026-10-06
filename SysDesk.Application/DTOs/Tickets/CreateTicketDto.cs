namespace SysDesk.Application.DTOs.Tickets;

public class CreateTicketDto
{
    public Guid ApplicationId { get; set; }
    public short TicketTypeId { get; set; }
    public short PriorityId { get; set; }
    public short SourceId { get; set; }
    public Guid? RequestedByPersonId { get; set; }
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
}
