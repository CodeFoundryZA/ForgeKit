namespace ForgeKit.Entities.Common;

public abstract class AuditedEntity<TId> : Entity<TId>, IAudited
{
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
    public Guid? CreatedById { get; set; }
    public Guid? UpdatedById { get; set; }
}
