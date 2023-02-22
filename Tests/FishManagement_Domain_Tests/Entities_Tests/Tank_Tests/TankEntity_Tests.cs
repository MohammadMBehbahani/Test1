namespace FishManagement_Domain_Tests.Entities_Tests.Tank_Tests;

[TestFixture]
public class TankEntity_Tests
{


    [Test]
    public void Tank_CreateTankEntityWithoutAnyException_ShoulReturnNewInstanseOfTankEntity()
    {
        //Arrage
        string tankName = "NewTank";
        //Act
        var tankInstanse = new Tank(tankName);
        //Assert
        Assert.NotNull(tankInstanse);
    }
}
