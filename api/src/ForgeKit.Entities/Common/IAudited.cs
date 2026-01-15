namespace ForgeKit.Entities.Common;

public interface IAudited
{
    DateTimeOffset CreatedAt { get; set; }
    DateTimeOffset? UpdatedAt { get; set; }
    Guid? CreatedById { get; set; }
    Guid? UpdatedById { get; set; }
}
