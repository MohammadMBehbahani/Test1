
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
    [Test]
    public void Fish_CreateFishEntityWithFishTypeNull_ThrowsArgumentException()
    {
        //Arrage
        var fishType = "";
        var fishFoodWeight = 0.1;
        //Act
        //Assert
        var exception = Assert.Throws<ArgumentException>(() =>
          {
              var fishEntity = new Fish(fishType, fishFoodWeight);
          });
        StringAssert.Contains("The food type muse be less than 140 charcter or not be null", exception.Message);
    }
    [Test]
    public void Fish_CreateFishEntityWithFishFoodWeightZero_ThrowsArgumentException()
    {
        //Arrage
        var fishType = "blue";
        var fishFoodWeight = 0;
        //Act
        //Assert
        var exception = Assert.Throws<ArgumentException>(() =>
        {
            var fishEntity = new Fish(fishType, fishFoodWeight);
        });
        StringAssert.Contains("Food weight muse be greater than 0", exception.Message);

    }
}
