using ForgeKit.Entities.Common;

namespace ForgeKit.Entities;

public sealed class UserIdentity : FullyAuditedEntity<Guid>
{
    public Guid UserId { get; set; }
    public string Provider { get; set; } = string.Empty;
    public string ExternalId { get; set; } = string.Empty;
    public DateTimeOffset? EmailVerifiedAt { get; set; }
}
