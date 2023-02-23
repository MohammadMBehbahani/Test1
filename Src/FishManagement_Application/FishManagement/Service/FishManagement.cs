namespace FishManagement_Application.FishManagement.Service;
public class FishManagement : IFishManagement
{
    private readonly ISqlBaseRepository<Fish> baseRepo;
    public FishManagement(ISqlBaseRepository<Fish> baseRepo)
    {
        this.baseRepo = baseRepo;
    }
    public async Task<ShowFishDto> CreateFishAsync(CreateFishDto dto)
    {
        var resultOfAddFishEnityty = await baseRepo.AddEntityAsync(new Fish(dto.FishName ?? "", dto.FishFoodWeight));
        return new ShowFishDto
        {
            FishType = resultOfAddFishEnityty.FishType,
            FishFoodWeight = resultOfAddFishEnityty.FishFoodWeight,
            FishId = resultOfAddFishEnityty.Id,
        };

    }

    public async Task<bool> DeleteFishAsync(Guid fishId)
    {
        return await baseRepo.DeleteEntityAsync(fishId);
    }

    public async Task<ShowFishDto> EditFishAsync(CreateFishDto dto, Guid fishId)
    {
        var endity = baseRepo.GetById(fishId);
        var updatedEntity = endity.UpdateClass(dto.FishName ?? "", dto.FishFoodWeight);
        var result = await baseRepo.EditEntityAsync(updatedEntity);
        return new ShowFishDto
        {
            FishFoodWeight = result.FishFoodWeight,
            FishType = result.FishType,
            FishId = result.Id,
        };
    }

    public ShowFishDto GetFishById(Guid fishId)
    {
        var fish = baseRepo.GetById(fishId);
        return new ShowFishDto
        {
            FishFoodWeight = fish.FishFoodWeight,
            FishId = fish.Id,
            FishType = fish.FishType,
        };
    }

    public async Task<IList<ShowFishDto>> GetFishListAsync()
    {
        var fishes = await baseRepo.GetListAsync();
        var fishList = new List<ShowFishDto>();
        for (int i = 0; i < fishes.Count; i++)
        {

            fishList.Add(new ShowFishDto
            {
                FishFoodWeight = fishes[i].FishFoodWeight,
                FishId = fishes[i].Id,
                FishType = fishes[i].FishType,
            });
        }
        return fishList;
    }
}
