using FishManagement_Application.Common.Interfaces.SqlBaseRepository;
using FishManagement_Application.Common.Models.Dto;
using FishManagement_Application.FishManagement;
using FishManagement_Domain.Entities;
using FishManagement_Infrastructure.Services.SqlBaseRepository;
using Moq;

namespace FishManagement_Application_Tests.FishManagement.Service;

[TestFixture]
public class FishManagement_Tests
{
    private readonly IFishManagement fishManagement;
    public FishManagement_Tests()
    {
        var sqlBaseRepository = new Mock<ISqlBaseRepository<Fish>>();

        fishManagement = new FishManagement_Application.FishManagement.Service.FishManagement(sqlBaseRepository.Object);
    }
    [Test]
    public async Task AddEntityAsync_CreateNewFishEntityAndAddToTheSqlDb_ShouldReturnSameEntityOfAdded()
    {
        //Arrage
        var fish = new CreateFishDto()
        {
            FishFoodWeight = 1.3,
            FishName = "gold_Sample",
        };
        //Act
        var resultOfAddEntity = await fishManagement.CreateFishAsync(fish);
        //Assert
        Assert.AreEqual(fish.FishName, resultOfAddEntity.FishType);
    }






}
