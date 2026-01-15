using ForgeKit.Entities.Common;

namespace ForgeKit.Entities;

public sealed class TenantMembership : IAudited, ISoftDelete
{
    public Guid TenantId { get; set; }
    public Guid UserId { get; set; }
    public Guid? RoleId { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public DateTimeOffset? UpdatedAt { get; set; }
    public Guid? CreatedById { get; set; }
    public Guid? UpdatedById { get; set; }
    public bool IsDeleted { get; set; }
    public DateTimeOffset? DeletedAt { get; set; }
    public Guid? DeletedById { get; set; }
}
