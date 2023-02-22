namespace FishManagement_Infrastructure.Persitence.SqlConfigurations.FishToTankConfiguration;

public class FishToTankConfugration : IEntityTypeConfiguration<FishToTank>
{
    public void Configure(EntityTypeBuilder<FishToTank> builder)
    {
        builder.HasKey(a => a.Id);

        builder.Property(a => a.FishName).HasMaxLength(140).IsRequired();
    }
}
