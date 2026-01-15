using ForgeKit.Entities.Common;

namespace ForgeKit.Entities;

public sealed class TokenPack : FullyAuditedEntity<Guid>
{
    public string Code { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public long Tokens { get; set; }
    public string? Currency { get; set; }
    public long UnitAmount { get; set; }
    public string? StripePriceId { get; set; }
    public bool IsActive { get; set; }
}
