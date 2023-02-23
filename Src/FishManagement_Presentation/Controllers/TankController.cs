namespace FishManagement_Presentation.Controllers;
public class TankController : ControllerBase
{
    private readonly ITankManagement tankManagement;

    public TankController(ITankManagement tankManagement)
    {
        this.tankManagement = tankManagement;
    }

    [HttpPost("CreateTank")]
    public async Task<ActionResult<ShowTankDto>> CreateTankAsync(CreateTankDto dto)
    {
        return Ok(await tankManagement.CreateTankAsync(dto));
    }
    [HttpDelete("DeleteTank")]
    public async Task<ActionResult<bool>> DeleteTankAsync(Guid tankId)
    {
        return Ok(await tankManagement.DeleteTankAsync(tankId));
    }
    [HttpPut("EditTank")]
    public async Task<ActionResult<ShowTankDto>> EditTankAsync(CreateTankDto dto, Guid tankId)
    {
        return Ok(await tankManagement.EditTankAsync(dto, tankId));
    }
    [HttpGet("GetTankById")]
    public ActionResult<ShowTankDto> GetTankById(Guid tankId)
    {
        return Ok(tankManagement.GetTankById(tankId));
    }
    [HttpGet("GetTankList")]
    public async Task<ActionResult<IList<ShowTankDto>>> GetTankLIstAsync()
    {
        return Ok(await tankManagement.GetTankListAsync());
    }
}
