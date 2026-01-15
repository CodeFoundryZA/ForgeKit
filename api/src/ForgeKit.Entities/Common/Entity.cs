namespace ForgeKit.Entities.Common;

public abstract class Entity<TId>
{
    public TId Id { get; set; } = default!;
    public byte[] RowVersion { get; set; } = Array.Empty<byte>();
}
