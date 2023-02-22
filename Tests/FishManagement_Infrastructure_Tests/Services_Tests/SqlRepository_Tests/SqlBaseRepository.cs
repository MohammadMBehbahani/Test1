using FishManagement_Domain.Entities;

namespace FishManagement_Infrastructure_Tests.Services_Tests.SqlRepository_Tests
{
    internal class SqlBaseRepository : ISqlBaseRepository
    {
        public object AddEntityAsync(Tank tank)
        {
            throw new NotImplementedException();
        }

        public object EditEntityAsync(Tank tankEdited, Guid tankId)
        {
            throw new NotImplementedException();
        }
    }
}