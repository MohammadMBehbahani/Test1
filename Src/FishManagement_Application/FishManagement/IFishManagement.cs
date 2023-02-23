

namespace FishManagement_Application.FishManagement;

public interface IFishManagement
{
    Task<ShowFishDto> CreateFishAsync(CreateFishDto dto);
    Task<ShowFishDto> EditFishAsync(CreateFishDto dto, Guid fishId);
    Task<bool> DeleteFishAsync(Guid fishId);
    ShowFishDto GetFishById(Guid fishId);
    Task<IList<ShowFishDto>> GetFishListAsync();
}
