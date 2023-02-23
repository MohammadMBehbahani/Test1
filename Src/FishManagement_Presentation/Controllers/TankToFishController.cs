namespace FishManagement_Presentation.Controllers;
public class TankToFishController : ControllerBase
{
    private readonly ITankToFishManagement fishToTankManagement;

    public TankToFishController(ITankToFishManagement fishToTankManagement)
    {
        this.fishToTankManagement = fishToTankManagement;
    }

    [HttpPost("CreateFishToTank")]
    public async Task<ActionResult<ShowFishToTankDto>> CreateFishToTankAsync(CreateFishToTankDto dto)
    {
        return Ok(await fishToTankManagement.CreateFishToTankAsync(dto));
    }
    [HttpGet("GetAllFishToTank")]
    public async Task GetFishesToTank(string tankName)
    {
        await fishToTankManagement.ShowFishToTankByTankNameAsnyc(tankName);
    }
}
