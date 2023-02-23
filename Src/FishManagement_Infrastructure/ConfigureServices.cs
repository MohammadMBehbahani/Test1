

namespace FishManagement_Infrastructure;
public static class ConfigureServices
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<ISqlDbContext>(provider => provider.GetRequiredService<SqlDbContext>());
        services.AddScoped(typeof(ISqlBaseRepository<>), typeof(SqlBaseRepository<>));
        services.AddScoped(typeof(IDictionaryStore<,>), typeof(DictionaryStore<,>));
        #region AddDbContext
        services.AddDbContext<SqlDbContext>(option =>
            option.UseSqlServer(configuration.GetConnectionString("LocalSqlServerConnection")));
        #endregion
        return services;
    }
}
