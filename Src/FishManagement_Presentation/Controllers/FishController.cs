namespace FishManagement_Presentation.Controllers;
public class FishController : ControllerBase
{
    private readonly IFishManagement fishManagement;

    public FishController(IFishManagement fishManagement)
    {
        this.fishManagement = fishManagement;
    }

    [HttpPost("CreateFish")]
    public async Task<ActionResult> CreateFishAsync(CreateFishDto dto)
    {
        return Ok(await fishManagement.CreateFishAsync(dto));
    }

    [HttpPut("EditFish")]
    public async Task<ActionResult> EditFishAsync(CreateFishDto dto, Guid fishId)
    {
        return Ok(await fishManagement.EditFishAsync(dto, fishId));
    }
    [HttpDelete("DeleteFish")]
    public async Task<ActionResult<bool>> DeleteFish(Guid fishId)
    {
        return Ok(await fishManagement.DeleteFishAsync(fishId));
    }
    [HttpGet("GetFishById")]
    public ActionResult<ShowFishDto> GetFishById(Guid fishId)
    {
        return Ok(fishManagement.GetFishById(fishId));
    }
    [HttpGet("GetFishes")]
    public async Task<ActionResult<ShowFishDto>> GetFishes()
    {
        return Ok(await fishManagement.GetFishListAsync());
    }
}
