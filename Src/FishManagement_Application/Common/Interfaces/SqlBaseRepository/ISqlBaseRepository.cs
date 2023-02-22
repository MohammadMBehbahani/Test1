namespace FishManagement_Application.Common.Interfaces.SqlBaseRepository;

public interface ISqlBaseRepository<TEntity>
{
    TEntity AddEntityAsync(TEntity entity);
    bool DeleteEntity(Guid tankId);
    TEntity EditEntityAsync(TEntity entity, Guid id);
}
