using ForgeKit.Entities.Common;

namespace ForgeKit.Entities;

public sealed class SubscriptionItem : FullyAuditedEntity<Guid>
{
    public Guid SubscriptionId { get; set; }
    public Guid? PlanId { get; set; }
    public string? StripeSubscriptionItemId { get; set; }
    public long Quantity { get; set; }
    public string? StripePriceId { get; set; }
    public bool IsMetered { get; set; }
}
