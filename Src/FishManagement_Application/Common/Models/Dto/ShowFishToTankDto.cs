namespace FishManagement_Application.Common.Models.Dto;

public class ShowFishToTankDto
{
    public Dictionary<string, string>? FishesDetails { get; set; }
    public double TotalFishFoodWeight { get; set; }

}
