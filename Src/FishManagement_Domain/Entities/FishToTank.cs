namespace FishManagement_Domain.Entities;

public class FishToTank : BaseEntity
{
    #region Properties
    public Guid TankId { get; set; }
    public Guid FishId { get; set; }
    public string? FishName { get; set; }
    #endregion
    #region Relations
    public Tank? Tank { get; set; }
    public Fish? Fish { get; set; }
    #endregion

}
