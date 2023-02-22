using FishManagement_Domain.Entities;

namespace FishManagement_Infrastructure_Tests.Services_Tests.SqlRepository_Tests
{
    internal interface ISqlBaseRepository
    {
        object AddEntityAsync(Tank tank);
        object DeleteEntity(Guid tankId);
        object EditEntityAsync(Tank tankEdited, Guid tankId);
    }
}