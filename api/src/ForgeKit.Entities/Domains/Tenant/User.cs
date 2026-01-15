using System.Text.Json;
using ForgeKit.Entities.Common;

namespace ForgeKit.Entities;

public sealed class User : FullyAuditedEntity<Guid>
{
    public Guid? DefaultTenantId { get; set; }
    public string? UserName { get; set; }
    public string Email { get; set; } = string.Empty;
    public string PasswordHash { get; set; } = string.Empty;
    public string? PhoneNumber { get; set; }
    public string? Timezone { get; set; }
    public string? Locale { get; set; }
    public JsonDocument? Properties { get; set; }
    public Guid? AvatarFileId { get; set; }
    public string? SignupSource { get; set; }
    public DateTimeOffset? LastSeen { get; set; }
    public bool IsActive { get; set; }
}
