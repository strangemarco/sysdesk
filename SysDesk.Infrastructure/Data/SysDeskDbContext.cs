using Microsoft.EntityFrameworkCore;
using SysDesk.Application.Interfaces.Data;
using SysDesk.Domain.Entities;

namespace SysDesk.Infrastructure.Data;

public class SysDeskDbContext : DbContext, ISysDeskDbContext
{
    public SysDeskDbContext(DbContextOptions<SysDeskDbContext> options) : base(options)
    {
    }

    public DbSet<Person> Persons => Set<Person>();
    public DbSet<User> Users => Set<User>();
    public DbSet<Role> Roles => Set<Role>();
    public DbSet<SysDesk.Domain.Entities.Application> Applications => Set<SysDesk.Domain.Entities.Application>();
    public DbSet<ApplicationModule> ApplicationModules => Set<ApplicationModule>();
    public DbSet<ApplicationUserRole> ApplicationUserRoles => Set<ApplicationUserRole>();
    public DbSet<TicketType> TicketTypes => Set<TicketType>();
    public DbSet<TicketPriority> TicketPriorities => Set<TicketPriority>();
    public DbSet<TicketStatus> TicketStatuses => Set<TicketStatus>();
    public DbSet<TicketSource> TicketSources => Set<TicketSource>();
    public DbSet<TicketCategory> TicketCategories => Set<TicketCategory>();
    public DbSet<Ticket> Tickets => Set<Ticket>();
    public DbSet<TicketAssignment> TicketAssignments => Set<TicketAssignment>();
    public DbSet<TicketComment> TicketComments => Set<TicketComment>();
    public DbSet<TicketAttachment> TicketAttachments => Set<TicketAttachment>();
    public DbSet<Tag> Tags => Set<Tag>();
    public DbSet<TicketTag> TicketTags => Set<TicketTag>();
    public DbSet<TicketWatcher> TicketWatchers => Set<TicketWatcher>();
    public DbSet<TicketContext> TicketContexts => Set<TicketContext>();
    public DbSet<TicketHistory> TicketHistory => Set<TicketHistory>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        // Configuraciones globales de esquema (Fluent API).
        // Se aplicarán las configuraciones de tablas, llaves primarias, foráneas, índices, etc.
        // Lo ideal es tener clases separadas (IEntityTypeConfiguration<T>) para no saturar este archivo.
        
        // Ejemplo de llaves compuestas:
        modelBuilder.Entity<ApplicationUserRole>()
            .HasKey(aur => new { aur.ApplicationId, aur.UserId, aur.RoleId });

        modelBuilder.Entity<TicketTag>()
            .HasKey(tt => new { tt.TicketId, tt.TagId });

        modelBuilder.Entity<TicketWatcher>()
            .HasKey(tw => new { tw.TicketId, tw.UserId });
            
        // Default values y precisiones que vimos en tu script SQL.
        modelBuilder.Entity<Person>().Property(p => p.Id).HasDefaultValueSql("NEWSEQUENTIALID()");
        modelBuilder.Entity<User>().Property(u => u.Id).HasDefaultValueSql("NEWSEQUENTIALID()");
        modelBuilder.Entity<SysDesk.Domain.Entities.Application>().Property(a => a.Id).HasDefaultValueSql("NEWSEQUENTIALID()");
        modelBuilder.Entity<Ticket>().Property(t => t.Id).HasDefaultValueSql("NEWSEQUENTIALID()");
        
        // Configuración para el Identity de TicketNumber
        modelBuilder.Entity<Ticket>()
            .Property(t => t.TicketNumber)
            .UseIdentityColumn();
    }
}
