namespace FishManagement_Application.TankManagement.Service;

public class TankManagement : ITankManagement
{
    private ISqlBaseRepository<Tank> repository;
    public TankManagement(ISqlBaseRepository<Tank> repository)
    {
        this.repository = repository;
    }

    public async Task<ShowTankDto> CreateTankAsync(CreateTankDto dto)
    {
        var resultOfAdd = await repository.AddEntityAsync(new Tank(dto.TankName));
        return new ShowTankDto
        {
            TankName = resultOfAdd.TankName,
            TankId = resultOfAdd.Id,
        };
    }

    public async Task<bool> DeleteTankAsync(Guid tankId)
    {
        var deleteTankAsync = await repository.DeleteEntityAsync(tankId);
        return deleteTankAsync;
    }

    public async Task<ShowTankDto> EditTankAsync(CreateTankDto dto, Guid tankId)
    {
        var entity = repository.GetById(tankId);
        var updatedEntity = entity.UpdateClass(dto.TankName);
        var oldEntity = await repository.EditEntityAsync(updatedEntity);
        return new ShowTankDto
        {
            TankName = oldEntity.TankName,
            TankId = oldEntity.Id,
        };
    }

    public ShowTankDto GetTankById(Guid tankId)
    {
        var tankEntity = repository.GetById(tankId);
        if (tankEntity is not null)
        {
            return new ShowTankDto
            {
                TankName = tankEntity.TankName,
                FishTotalFoodWeight = tankEntity.FishTotalFoodWeight,
                TankId = tankEntity.Id,
            };
        }
        return new ShowTankDto();
    }

    public async Task<IList<ShowTankDto>> GetTankListAsync()
    {
        var showTankListDto = new List<ShowTankDto>();
        var tanks = await repository.GetListAsync();
        for (int i = 0; i < tanks.Count; i++)
        {
            showTankListDto.Add(new ShowTankDto
            {
                FishTotalFoodWeight = tanks[i].FishTotalFoodWeight,
                TankName = tanks[i].TankName,
                TankId = tanks[i].Id,
            });
        }
        return showTankListDto;
    }
}
