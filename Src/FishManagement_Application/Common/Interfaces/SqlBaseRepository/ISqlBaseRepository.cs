namespace FishManagement_Application.Common.Interfaces.SqlBaseRepository;

public interface ISqlBaseRepository<TEntity> where TEntity : BaseEntity
{
    Task<TEntity> AddEntityAsync(TEntity entity);
    Task<bool> DeleteEntityAsync(Guid tankId);
    Task<TEntity> EditEntityAsync(TEntity entity);
    Task<IList<TEntity>> GetListAsync();
    TEntity GetById(Guid fishId);

}
