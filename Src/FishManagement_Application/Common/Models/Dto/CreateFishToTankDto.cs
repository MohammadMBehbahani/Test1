namespace FishManagement_Application.Common.Models.Dto;

public class CreateFishToTankDto
{
    public string? TankName { get; set; }
    public IList<string>? FishTypes { get; set; }
    public IList<string>? FishesName { get; set; }
}
