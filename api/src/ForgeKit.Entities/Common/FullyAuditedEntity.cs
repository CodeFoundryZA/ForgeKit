namespace ForgeKit.Entities.Common;

public abstract class FullyAuditedEntity<TId> : AuditedEntity<TId>, ISoftDelete
{
    public bool IsDeleted { get; set; }
    public DateTimeOffset? DeletedAt { get; set; }
    public Guid? DeletedById { get; set; }
}
