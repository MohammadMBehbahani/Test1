using FishManagement_Application.TankManagement;

namespace FishManagement_Application;
public static class ConfigureServices
{
    public static IServiceCollection AddApplicationService(this IServiceCollection services)
    {
        services.AddScoped<IFishManagement, FishManagement.Service.FishManagement>();
        services.AddScoped<ITankManagement, TankManagement.Service.TankManagement>();
        return services;
    }
}
