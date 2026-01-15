using ForgeKit.Entities.Common;

namespace ForgeKit.Entities;

public sealed class Subscription : FullyAuditedEntity<Guid>
{
    public Guid TenantId { get; set; }
    public Guid? PlanId { get; set; }
    public string? StripeSubscriptionId { get; set; }
    public string? Status { get; set; }
    public bool IsActive { get; set; }
    public string? CollectionMethod { get; set; }
    public Guid? DefaultPaymentMethodId { get; set; }
    public DateTimeOffset? CurrentPeriodStart { get; set; }
    public DateTimeOffset? CurrentPeriodEnd { get; set; }
    public string? ExternalCustomerId { get; set; }
    public string? ExternalSubId { get; set; }
    public DateTimeOffset? TrialEnd { get; set; }
}
