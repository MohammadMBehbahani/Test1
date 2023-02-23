

namespace FishManagement_Infrastructure_Tests.Services_Tests.SqlRepository_Tests;

[TestFixture]
public class SqlBaseRepository_Tests
{
    private readonly ISqlBaseRepository<Tank> sqlBaseRepository;
    private Mock<ISqlDbContext> dbContext;
    public SqlBaseRepository_Tests()
    {
        dbContext = new Mock<ISqlDbContext>();
        sqlBaseRepository = new SqlBaseRepository<Tank>(dbContext.Object);
    }
    [Test]
    public void AddEntityAsync_CreateTankEntityFromDataBase_GetsTankDbWithSameId()
    {
        //Arrage
        var tank = new Tank("FirsTank");
        //Act
        var resultOfAdd = sqlBaseRepository.AddEntityAsync(tank);
        //Assert
        Assert.Equals(resultOfAdd, tank);
    }
    [Test]
    public void EditEntityAsync_EditTankEntityFromDataBase_ReturnTankEntityLikeInputEditedEntiy()
    {
        //Arrage
        var tankId = Guid.NewGuid();
        var tankEdited = new Tank("towfish");
        //Act
        //var resultOfAdd = sqlBaseRepository.EditEntityAsync(tankEdited, tankId);
        //Assert
        //Assert.AreEqual(tankEdited, resultOfAdd);
    }
    [Test]
    public async Task Create_DeleteTankEntityFromDataBase_ReturnTrueOfDelete()
    {
        //Arrage
        var tankId = Guid.NewGuid();
        //Act
        var resultOfAdd =await sqlBaseRepository.DeleteEntityAsync(tankId);
        //Assert
        Assert.AreEqual(true, resultOfAdd);
    }

}
