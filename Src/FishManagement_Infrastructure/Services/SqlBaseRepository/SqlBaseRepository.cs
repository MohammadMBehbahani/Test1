

namespace FishManagement_Infrastructure.Services.SqlBaseRepository;

public class SqlBaseRepository<T> : ISqlBaseRepository<T>
{
    public T AddEntityAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public bool DeleteEntity(Guid tankId)
    {
        throw new NotImplementedException();
    }

    public T EditEntityAsync(T entity, Guid id)
    {
        throw new NotImplementedException();
    }
}
