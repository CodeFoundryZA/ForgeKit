using ForgeKit.Entities.Common;

namespace ForgeKit.Entities;

public sealed class AutoTopupSettings : FullyAuditedEntity<Guid>
{
    public Guid WalletId { get; set; }
    public bool Enabled { get; set; }
    public long TresholdTokens { get; set; }
    public Guid TokenPackId { get; set; }
    public int PackMultiplier { get; set; }
    public Guid? DefaultPaymentMethodId { get; set; }
}
