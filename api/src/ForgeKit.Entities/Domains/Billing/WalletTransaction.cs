using ForgeKit.Entities.Common;

namespace ForgeKit.Entities;

public sealed class WalletTransaction : FullyAuditedEntity<Guid>
{
    public Guid WalletId { get; set; }
    public Guid TenantId { get; set; }
    public string? Direction { get; set; }
    public string? ReasonCode { get; set; }
    public long Tokens { get; set; }
    public Guid? RelatedUsageRecordId { get; set; }
    public Guid? TokenPackId { get; set; }
    public string? StripeCheckoutSessionId { get; set; }
    public string? StripePaymentIntentId { get; set; }
    public string? StripeInvoiceId { get; set; }
    public DateTimeOffset? ExpiresAt { get; set; }
    public Guid? CreatedByUserId { get; set; }
    public string? StripeCreditGrantId { get; set; }
}
