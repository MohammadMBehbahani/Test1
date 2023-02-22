

namespace FishManagement_Domain.Entities;

public class Tank : BaseEntity
{
    #region Properties
    public string? TankName { get; private set; }
    #endregion

    #region Builder
    public Tank(string tankName)
    {
        CheckTankNameNotBeNull(tankName);
    }
    #endregion

    #region Methods
    private void CheckTankNameNotBeNull(string tankName)
    {
        if (string.IsNullOrEmpty(tankName) || tankName.Length > 140)
            throw new ArgumentException("Tank Name should have 140 character or not be null");
        this.TankName = tankName;
    }

    #endregion

}
