using ForgeKit.Entities.Common;

namespace ForgeKit.Entities;

public sealed class Invoice : FullyAuditedEntity<Guid>
{
    public Guid TenantId { get; set; }
    public string? StripeInvoiceId { get; set; }
    public string? Status { get; set; }
    public long AmountDue { get; set; }
    public long AmountPaid { get; set; }
    public long AmountRemaining { get; set; }
    public DateTimeOffset? DueDate { get; set; }
    public DateTimeOffset? PaidAt { get; set; }
    public string? HostedInvoiceUrl { get; set; }
    public Guid? SubscriptionId { get; set; }
    public string? CollectionMethod { get; set; }
}
