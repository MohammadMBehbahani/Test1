namespace FishManagement_Domain_Tests.Entities_Tests.Fish_Tests;

[TestFixture]
public class FishEntity_Tests
{


    [Test]
    public void Fish_CreateFishEntity_CreateNewInstanceOfFishEntity()
    {
        //Arrage
        var fishType = "gold";
        var fishFoodWeight = 0.1;
        //Act
        var fishEntity = new Fish(fishType, fishFoodWeight);
        //Assert
        Assert.NotNull(fishEntity);

    }
}
