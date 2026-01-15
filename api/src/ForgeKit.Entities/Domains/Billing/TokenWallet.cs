using ForgeKit.Entities.Common;

namespace ForgeKit.Entities;

public sealed class TokenWallet : FullyAuditedEntity<Guid>
{
    public Guid TenantId { get; set; }
    public long BalanceCachedTokens { get; set; }
    public long PendingHoldTokens { get; set; }
}
