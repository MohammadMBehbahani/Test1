namespace FishManagement_Domain.Entities;

public class Fish : BaseEntity
{
    #region Properties
    public string? FishType { get; private set; }
    public double FishFoodWeight { get; private set; }
    #endregion
    #region Builder
    public Fish(string fishType, double foodweight) : this()
    {
        CheckFishTypeValidation(fishType);
        CheckFoodWeightValidation(foodweight);
    }
    private Fish()
    {

    }
    #endregion
    #region Methods
    public void CheckFishTypeValidation(string fishType)
    {
        if (fishType.Length > 140 || String.IsNullOrWhiteSpace(fishType))
            throw new ArgumentException("The food type muse be less than 140 charcter or not be null");
        this.FishType = fishType;
    }
    public void CheckFoodWeightValidation(double foodWeight)
    {
        if (foodWeight is 0)
            throw new ArgumentException("Food weight muse be greater than 0");
        this.FishFoodWeight = foodWeight;
    }
    public Fish UpdateClass(string fishType, double foodweight)
    {
        CheckFishTypeValidation(fishType);
        CheckFoodWeightValidation(foodweight);
        return this;
    }
    #endregion
    #region Relations
    public IList<FishToTank> FishToTanks { get; set; }
    #endregion
}
