using FishManagement_Domain.Entities;

namespace FishManagement_Application.TankToFishManagement.Service;
public class TankToFishManagement : ITankToFishManagement
{

    private readonly ISqlDbContext dbContext;
    private readonly IDictionaryStore<string, string> dictionaryManager;
    public TankToFishManagement(ISqlDbContext dbContext
        , IDictionaryStore<string, string> dictionaryManager)
    {
        this.dbContext = dbContext;
        this.dictionaryManager = dictionaryManager;
    }

    public async Task<ShowFishToTankDto> CreateFishToTankAsync(CreateFishToTankDto dto)
    {
        var tank = await dbContext.Tanks.Where(a => a.TankName.Equals(dto.TankName)).FirstOrDefaultAsync();
        
        
        var previosFishType = "";
       
        
        Fish fish = null;
      
        
        for (int i = 0; i < dto.FishTypes.Count; i++)
        {
            if (!dto.FishTypes[i].Equals(previosFishType))
            {
                fish = await dbContext.Fishes.Where(a => a.FishType.Equals(dto.FishTypes[i])).FirstOrDefaultAsync();
                previosFishType = dto.FishTypes[i];
            }

            var result = await dbContext.FishToTanks.AddAsync(new FishToTank(dto.FishesName[i], tank.Id, fish.Id));

            tank.FishTotalFoodWeight += fish.FishFoodWeight;


            dictionaryManager.AddNewDictionary(dto.FishesName[i], fish.FishType);
        }

        await dbContext.SaveChangesAsync();
        return new ShowFishToTankDto
        {
            TotalFishFoodWeight = tank.FishTotalFoodWeight,
            FishesDetails = dictionaryManager.GetAllDictionaryData(),
        };
    }

    public async Task<ShowFishToTankDto> ShowFishToTankByTankNameAsnyc(string tankName)
    {
        var listOfFishesToTank = await dbContext.Tanks.Where(a => a.TankName.Equals("msoheil"))
            .Include(a => a.FishToTanks).ThenInclude(s => s.Fish).ToListAsync();


        var tankTotalWeight = 0.0;



        foreach (var item in listOfFishesToTank)
        {
            tankTotalWeight = item.FishTotalFoodWeight;
            foreach (var fish in item.FishToTanks)
            {
                dictionaryManager.AddNewDictionary(fish.FishName ?? "", fish.Fish.FishType ?? "");
            }
        }


        return new ShowFishToTankDto
        {
            TotalFishFoodWeight = tankTotalWeight,
            FishesDetails = dictionaryManager.GetAllDictionaryData(),
        };
    }
}
