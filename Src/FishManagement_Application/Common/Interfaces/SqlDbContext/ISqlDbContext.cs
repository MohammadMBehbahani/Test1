namespace FishManagement_Application.Common.Interfaces.SqlDbContext;
public interface ISqlDbContext
{
    public DbSet<Tank> Tanks { get; }
    public DbSet<Fish> Fishes { get; }
    public DbSet<FishToTank> FishToTanks { get; }
    Task<int> SaveChangesAsync();
    DbSet<T> GetSet<T>() where T : BaseEntity;
}
