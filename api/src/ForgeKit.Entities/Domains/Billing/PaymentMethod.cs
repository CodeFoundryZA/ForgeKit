using ForgeKit.Entities.Common;

namespace ForgeKit.Entities;

public sealed class PaymentMethod : FullyAuditedEntity<Guid>
{
    public Guid TenantId { get; set; }
    public string? StripePaymentMethodId { get; set; }
    public string? Type { get; set; }
    public string? Brand { get; set; }
    public string? Last4 { get; set; }
    public int? ExpMonth { get; set; }
    public int? ExpYear { get; set; }
    public bool IsDefault { get; set; }
}
