using ForgeKit.Entities.Common;

namespace ForgeKit.Entities;

public sealed class TenantInvite : FullyAuditedEntity<Guid>
{
    public Guid TenantId { get; set; }
    public string Email { get; set; } = string.Empty;
    public DateTimeOffset? ExpiresAt { get; set; }
    public DateTimeOffset? AcceptedAt { get; set; }
    public Guid? InvitedByUserId { get; set; }
}
