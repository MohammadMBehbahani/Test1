namespace FishManagement_Domain.Entities;

public class FishToTank : BaseEntity
{
    #region Properties
    public Guid TankId { get; set; }
    public Guid FishId { get; set; }
    public string? FishName { get; set; }
    #endregion
    #region Builder
    public FishToTank(string fishName, Guid tankId, Guid
        fishId)
    {
        FishNameValidation(fishName);
        CheckTankIdValidation( tankId);
        CheckFishIdValidation( fishId);
    }
    private FishToTank()
    {

    }
    #endregion
    #region Relations
    public Tank? Tank { get; set; }
    public Fish? Fish { get; set; }
    #endregion
    #region Methods
    private void FishNameValidation(string fishName)
    {
        if (fishName.Length > 140 || String.IsNullOrWhiteSpace(fishName))
            throw new ArgumentException("fishName shoud be less than 140 charcter or don't be null");
        this.FishName = fishName;
    }
    private void CheckTankIdValidation(Guid tankId)
    {
        if (tankId.Equals(Guid.Empty))
            throw new ArgumentException("tankid must not be null");
        this.TankId = tankId;
    }
    private void CheckFishIdValidation(Guid fishId)
    {
        if (fishId.Equals(Guid.Empty))
            throw new ArgumentException("fishId must not be null");
        this.TankId = fishId;
    }
    #endregion

}
