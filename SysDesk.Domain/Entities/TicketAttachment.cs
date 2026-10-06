namespace SysDesk.Domain.Entities;

public class TicketAttachment
{
    public Guid Id { get; set; }
    public Guid TicketId { get; set; }
    public Guid? CommentId { get; set; }
    public Guid UploadedByUserId { get; set; }
    public string OriginalFileName { get; set; } = null!;
    public string StoredFileName { get; set; } = null!;
    public string StorageProvider { get; set; } = null!;
    public string StoragePath { get; set; } = null!;
    public string? ContentType { get; set; }
    public long FileSizeBytes { get; set; }
    public DateTime CreatedAt { get; set; }
    public bool IsDeleted { get; set; }
    public DateTime? DeletedAt { get; set; }

    public Ticket Ticket { get; set; } = null!;
    public TicketComment? Comment { get; set; }
    public User UploadedByUser { get; set; } = null!;
}
