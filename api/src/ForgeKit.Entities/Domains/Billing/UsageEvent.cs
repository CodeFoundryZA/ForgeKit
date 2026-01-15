using ForgeKit.Entities.Common;

namespace ForgeKit.Entities;

public sealed class UsageEvent : FullyAuditedEntity<Guid>
{
    public Guid TenantId { get; set; }
    public string? StripeMeterId { get; set; }
    public string? StripeMeterEventId { get; set; }
    public long Quantity { get; set; }
    public DateTimeOffset RecordedAt { get; set; }
    public string? PriceId { get; set; }
    public Guid? WalletTransactionId { get; set; }
}
