namespace ForgeKit.Entities;

public sealed class UserSettings
{
    public Guid UserId { get; set; }
    public string? Theme { get; set; }
    public bool NotifyOnTicketAssigned { get; set; }
    public bool NotifyOnReviewAssigned { get; set; }
    public bool NotifyOnPublish { get; set; }
}
