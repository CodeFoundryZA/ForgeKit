using ForgeKit.Entities.Common;

namespace ForgeKit.Entities;

public sealed class Role : FullyAuditedEntity<Guid>
{
    public Guid TenantId { get; set; }
    public string Name { get; set; } = string.Empty;
}
