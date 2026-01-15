using System.Text.Json;
using ForgeKit.Entities.Common;

namespace ForgeKit.Entities;

public sealed class Tenant : FullyAuditedEntity<Guid>
{
    public Guid? LogoFileId { get; set; }
    public string? Status { get; set; }
    public string? VanityDomain { get; set; }
    public bool IsActive { get; set; }
    public JsonDocument? Properties { get; set; }
    public string? StripeCustomerId { get; set; }
    public string? CountryCode { get; set; }
    public string? DefaultCurrency { get; set; }
}
