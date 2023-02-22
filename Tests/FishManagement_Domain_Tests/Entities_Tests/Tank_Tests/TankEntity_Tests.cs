using FishManagement_Domain.Entities;

namespace FishManagement_Domain_Tests.Entities_Tests.Tank_Tests;

[TestFixture]
public class TankEntity_Tests
{


    [Test]
    public void Tank_CreateTankEntityWithoutAnyException_ShouldReturnNewInstanseOfTankEntity()
    {
        //Arrage
        string tankName = "NewTank";
        //Act
        var tankInstanse = new Tank(tankName);
        //Assert
        Assert.NotNull(tankInstanse);
    }
    [Test]
    public void Tank_CreateTankEntityWithEmptyString_ShouldReturnException()
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
    [Test]
    public void Tank_SetTotalFoodWeight_ShouldReturnTotalWeight()
    {
        //Arrage
        string tankName = "sampl-tank";
        var weightOfTotalFishFood = 12.4;
        //Act
        var tank = new Tank(tankName);
        var resultOfSetFishTotalFoodWeight = tank.SetFishTotalFoodWeight(weightOfTotalFishFood);
        //Assert
        Assert.AreEqual(weightOfTotalFishFood, resultOfSetFishTotalFoodWeight);
    }
}
