namespace FishManagement_Application.TankManagement;

public interface ITankManagement
{
    Task<ShowTankDto> CreateTankAsync(CreateTankDto dto);
    Task<ShowTankDto> EditTankAsync(CreateTankDto dto, Guid tankId);
    Task<bool> DeleteTankAsync(Guid tankId);
    ShowTankDto GetTankById(Guid tankId);
    Task<IList<ShowTankDto>> GetTankListAsync();
}
