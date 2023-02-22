

namespace FishManagement_Domain.Entities;

public class Tank : BaseEntity
{
    #region Properties
    public string? TankName { get; private set; }
    public double FishTotalFoodWeight { get; set; }
    #endregion

    #region Builder
    public Tank(string tankName)
    {
        CheckTankNameNotBeNull(tankName);
    }
    private Tank()
    {

    }
    #endregion

    #region Methods
    private void CheckTankNameNotBeNull(string tankName)
    {
        if (string.IsNullOrEmpty(tankName) || tankName.Length > 140)
            throw new ArgumentException("Tank Name should have 140 character or not be null");
        this.TankName = tankName;
    }
    public double SetFishTotalFoodWeight(double fishTotalFoodWeight)
    {
        if (!fishTotalFoodWeight.Equals(0))
        {
            this.FishTotalFoodWeight = fishTotalFoodWeight;
            return this.FishTotalFoodWeight;
        }
        return 0;
    }
    #endregion
    #region Relations
    public IList<FishToTank> FishToTanks { get; set; }
    #endregion
}
