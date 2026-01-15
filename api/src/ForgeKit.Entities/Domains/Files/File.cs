using System.Text.Json;
using ForgeKit.Entities.Common;

namespace ForgeKit.Entities;

public sealed class File : FullyAuditedEntity<Guid>
{
    public Guid TenantId { get; set; }
    public string StorageKey { get; set; } = string.Empty;
    public string OriginalFilename { get; set; } = string.Empty;
    public string MimeType { get; set; } = string.Empty;
    public long SizeBytes { get; set; }
    public string? Checksum { get; set; }
    public JsonDocument? Metadata { get; set; }
}
