namespace FishManagement_Infrastructure.Services.SqlDbContext;
public class SqlDbContext : DbContext, ISqlDbContext
{
    public SqlDbContext(DbContextOptions<SqlDbContext> options) : base(options)
    {

    }
    public DbSet<Tank> Tanks => Set<Tank>();
    public DbSet<Fish> Fishes => Set<Fish>();
    public DbSet<FishToTank> FishToTanks => Set<FishToTank>();
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        base.OnModelCreating(builder);
    }
    public async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
    {
        return await base.SaveChangesAsync(cancellationToken); ;
    }
}
