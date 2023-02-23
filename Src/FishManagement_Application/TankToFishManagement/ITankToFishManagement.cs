namespace FishManagement_Application.TankToFishManagement;

public interface ITankToFishManagement
{
    Task<ShowFishToTankDto> CreateFishToTankAsync(CreateFishToTankDto dto);
    Task<ShowFishToTankDto> ShowFishToTankByTankNameAsnyc(string tankName);
}
