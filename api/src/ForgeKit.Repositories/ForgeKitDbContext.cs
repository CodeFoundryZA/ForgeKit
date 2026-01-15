using System.Linq.Expressions;
using System.Text;
using ForgeKit.Entities;
using ForgeKit.Entities.Common;
using Microsoft.EntityFrameworkCore;
using FileEntity = ForgeKit.Entities.File;

namespace ForgeKit.Repositories;

public sealed class ForgeKitDbContext : DbContext
{
    public ForgeKitDbContext(DbContextOptions<ForgeKitDbContext> options, Func<Guid?>? currentUserIdProvider = null)
        : base(options)
    {
        CurrentUserIdProvider = currentUserIdProvider;
    }

    public Func<Guid?>? CurrentUserIdProvider { get; }

    public DbSet<AutoTopupSettings> AutoTopupSettings => Set<AutoTopupSettings>();
    public DbSet<FileEntity> Files => Set<FileEntity>();
    public DbSet<Invoice> Invoices => Set<Invoice>();
    public DbSet<PaymentMethod> PaymentMethods => Set<PaymentMethod>();
    public DbSet<Plan> Plans => Set<Plan>();
    public DbSet<Role> Roles => Set<Role>();
    public DbSet<RolePermission> RolePermissions => Set<RolePermission>();
    public DbSet<Subscription> Subscriptions => Set<Subscription>();
    public DbSet<SubscriptionItem> SubscriptionItems => Set<SubscriptionItem>();
    public DbSet<Tenant> Tenants => Set<Tenant>();
    public DbSet<TenantInvite> TenantInvites => Set<TenantInvite>();
    public DbSet<TenantMembership> TenantMemberships => Set<TenantMembership>();
    public DbSet<TokenPack> TokenPacks => Set<TokenPack>();
    public DbSet<TokenWallet> TokenWallets => Set<TokenWallet>();
    public DbSet<UsageEvent> UsageEvents => Set<UsageEvent>();
    public DbSet<User> Users => Set<User>();
    public DbSet<UserIdentity> UserIdentities => Set<UserIdentity>();
    public DbSet<UserSettings> UserSettings => Set<UserSettings>();
    public DbSet<WalletTransaction> WalletTransactions => Set<WalletTransaction>();

    public override int SaveChanges()
    {
        ApplyAuditRules();
        return base.SaveChanges();
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        ApplyAuditRules();
        return base.SaveChangesAsync(cancellationToken);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<RolePermission>()
            .HasKey(rolePermission => new { rolePermission.RoleId, rolePermission.Permission });
        modelBuilder.Entity<TenantMembership>()
            .HasKey(tenantMembership => new { tenantMembership.TenantId, tenantMembership.UserId });
        modelBuilder.Entity<UserSettings>()
            .HasKey(userSettings => userSettings.UserId);

        foreach (var entityType in modelBuilder.Model.GetEntityTypes())
        {
            var tableName = entityType.ClrType == typeof(FileEntity)
                ? "file_entity"
                : ToSnakeCase(entityType.ClrType.Name);
            entityType.SetTableName(tableName);

            foreach (var property in entityType.GetProperties())
            {
                property.SetColumnName(ToSnakeCase(property.Name));
            }

            if (typeof(ISoftDelete).IsAssignableFrom(entityType.ClrType))
            {
                var parameter = Expression.Parameter(entityType.ClrType, "entity");
                var isDeletedProperty = Expression.Property(parameter, nameof(ISoftDelete.IsDeleted));
                var notDeleted = Expression.Equal(isDeletedProperty, Expression.Constant(false));
                var filter = Expression.Lambda(notDeleted, parameter);
                entityType.SetQueryFilter(filter);
            }

            var rowVersionProperty = entityType.FindProperty("RowVersion");
            if (rowVersionProperty is null)
            {
                continue;
            }

            modelBuilder.Entity(entityType.ClrType)
                .Property<byte[]>("RowVersion")
                .IsRowVersion();
        }
    }

    private void ApplyAuditRules()
    {
        var now = DateTimeOffset.UtcNow;
        var currentUserId = CurrentUserIdProvider?.Invoke();

        foreach (var entry in ChangeTracker.Entries())
        {
            if (entry.State is EntityState.Detached or EntityState.Unchanged)
            {
                continue;
            }

            if (entry.Entity is ISoftDelete softDelete && entry.State == EntityState.Deleted)
            {
                entry.State = EntityState.Modified;
                softDelete.IsDeleted = true;
                softDelete.DeletedAt = now;
                if (currentUserId.HasValue)
                {
                    softDelete.DeletedById = currentUserId.Value;
                }
            }

            if (entry.Entity is not IAudited audited)
            {
                continue;
            }

            if (entry.State == EntityState.Added)
            {
                audited.CreatedAt = now;
                if (currentUserId.HasValue)
                {
                    audited.CreatedById = currentUserId.Value;
                }
            }
            else if (entry.State == EntityState.Modified)
            {
                audited.UpdatedAt = now;
                if (currentUserId.HasValue)
                {
                    audited.UpdatedById = currentUserId.Value;
                }

                entry.Property(nameof(IAudited.CreatedAt)).IsModified = false;
                entry.Property(nameof(IAudited.CreatedById)).IsModified = false;
            }
        }
    }

    private static string ToSnakeCase(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return value;
        }

        var builder = new StringBuilder();
        for (var index = 0; index < value.Length; index++)
        {
            var character = value[index];
            if (char.IsUpper(character))
            {
                if (index > 0)
                {
                    builder.Append('_');
                }

                builder.Append(char.ToLowerInvariant(character));
                continue;
            }

            builder.Append(character);
        }

        return builder.ToString();
    }
}
