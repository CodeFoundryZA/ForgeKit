using ForgeKit.Entities.Common;

namespace ForgeKit.Entities;

public sealed class Plan : FullyAuditedEntity<Guid>
{
    public string Name { get; set; } = string.Empty;
    public long TokenLimit { get; set; }
    public string? StripeProductId { get; set; }
    public string? StripePriceId { get; set; }
    public bool IsActive { get; set; }
}
