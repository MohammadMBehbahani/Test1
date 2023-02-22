using FishManagement_Domain.Entities;

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
    [Test]
    public void Tank_CreateTankEntityWithEmptyString_ShoulReturnException()
    {
        //Arrage
        string tankName = "";
        //Act
      
        //Assert
        var execption = Assert.Throws<ArgumentException>(() =>
        {
            var tankInstanse = new Tank(tankName);
        });
        StringAssert.Contains(
            "Tank Name should have 140 character or not be null", execption.Message);
    }
}
