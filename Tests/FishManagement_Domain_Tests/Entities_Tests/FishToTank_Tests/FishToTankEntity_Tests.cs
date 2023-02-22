namespace FishManagement_Domain_Tests.Entities_Tests.FishToTank_Tests;



[TestFixture]
public class FishToTankEntity_Tests
{
    [Test]
    public void FishToTank_CreateFishToTankEntity_ShouldReturnNewInstance()
    {
        //Arrage
        string fishName = "sampl-name";
        var tankId = Guid.NewGuid();
        var fishId = Guid.NewGuid();
        //Act
        var tank = new FishToTank(fishName, tankId, fishId);
        //Assert
        Assert.IsNotNull(tank);

    }
    [Test]
    public void FishToTank_CreateFishToTankEntityWithNullFishName_ShouldReturnArgumentException()
    {
        //Arrage
        string fishName = "";
        var tankId = Guid.NewGuid();
        var fishId = Guid.NewGuid();
        //Act
        var exception = Assert.Throws<ArgumentException>(() =>
        {
            var tank = new FishToTank(fishName, tankId, fishId);

        });
        //Assert
        StringAssert.Contains("fishName shoud be less than 140 charcter or don't be null", exception.Message);

    }
    [Test]
    public void FishToTank_CreateFishToTankEntityWithNullTankId_ShouldReturnArgumentException()
    {
        //Arrage
        string fishName = "sample-name";
        var tankId = Guid.Empty;
        var fishId = Guid.NewGuid();
        //Act
        var exception = Assert.Throws<ArgumentException>(() =>
        {
            var tank = new FishToTank(fishName, tankId, fishId);

        });
        //Assert
        StringAssert.Contains("tankid must not be null", exception.Message);

    }
    [Test]
    public void FishToTank_CreateFishToTankEntityWithNullfishId_ShouldReturnArgumentException()
    {
        //Arrage
        string fishName = "sample-name";
        var tankId = Guid.NewGuid();
        var fishId = Guid.Empty;
        //Act
        var exception = Assert.Throws<ArgumentException>(() =>
        {
            var tank = new FishToTank(fishName, tankId, fishId);

        });
        //Assert
        StringAssert.Contains("fishId must not be null", exception.Message);

    }

}

