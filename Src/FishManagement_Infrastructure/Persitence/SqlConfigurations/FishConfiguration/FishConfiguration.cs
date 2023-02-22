

namespace FishManagement_Infrastructure.Persitence.SqlConfigurations.FishConfiguration;

public class FishConfiguration : IEntityTypeConfiguration<Fish>
{
    public void Configure(EntityTypeBuilder<Fish> builder)
    {
        #region Configuration
        builder.HasKey(a => a.Id);
        builder.Property(a => a.FishType).HasMaxLength(140).IsRequired();
        #endregion
        #region Relations
        builder.HasMany(a => a.FishToTanks)
            .WithOne(a => a.Fish).HasForeignKey(a => a.FishId)
            .IsRequired();
        #endregion
    }
}
