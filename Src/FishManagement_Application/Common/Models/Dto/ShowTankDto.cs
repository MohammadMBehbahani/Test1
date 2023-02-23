namespace FishManagement_Application.Common.Models.Dto;

public class ShowTankDto
{
    public Guid TankId { get; set; }
    public string? TankName { get; set; }
    public double FishTotalFoodWeight { get; set; }
}
