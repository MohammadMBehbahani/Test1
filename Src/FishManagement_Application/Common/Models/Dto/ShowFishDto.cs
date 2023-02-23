namespace FishManagement_Application.Common.Models.Dto;

public class ShowFishDto
{
    public Guid FishId { get; set; }
    public string? FishType { get; set; }
    public double FishFoodWeight { get; set; }
}
