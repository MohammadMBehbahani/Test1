namespace FishManagement_Infrastructure.Persitence.SqlConfigurations.TankConfiguration;

public class TankConfiguration : IEntityTypeConfiguration<Tank>
{
    public void Configure(EntityTypeBuilder<Tank> builder)
    {
        #region Configuration
        builder.HasKey(a => a.Id);

        builder.Property(a => a.TankName).HasMaxLength(140).IsRequired();
        #endregion

        #region Relations
        builder.HasMany(a => a.FishToTanks).WithOne(a => a.Tank)
            .HasForeignKey(a => a.TankId).IsRequired();
        #endregion
    }
}
