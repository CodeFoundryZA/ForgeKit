using ForgeKit.Entities.Common;

namespace ForgeKit.Entities;

public sealed class Charge : FullyAuditedEntity<Guid>
{
    public Guid TenantId { get; set; }
    public string? StripeChargeId { get; set; }
    public string? Status { get; set; }
    public long Amount { get; set; }
    public string? Currency { get; set; }
    public string? FailureCode { get; set; }
    public string? FailureMessage { get; set; }
}
