namespace ForgeKit.Entities.Common;

public interface ISoftDelete
{
    bool IsDeleted { get; set; }
    DateTimeOffset? DeletedAt { get; set; }
    Guid? DeletedById { get; set; }
}
