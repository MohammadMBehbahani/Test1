

namespace FishManagement_Infrastructure.Services.SqlBaseRepository;
public class SqlBaseRepository<T> : ISqlBaseRepository<T> where T : BaseEntity
{
    private readonly ISqlDbContext dbContext;
    private readonly DbSet<T> dbSet;
    public SqlBaseRepository(ISqlDbContext dbContext)
    {
        this.dbContext = dbContext;
        dbSet = dbContext.GetSet<T>();
    }

    public async Task<T> AddEntityAsync(T entity)
    {
        var resultOfAddEntity = await dbSet.AddAsync(entity);
        await dbContext.SaveChangesAsync();
        return resultOfAddEntity.Entity;
    }

    public async Task<bool> DeleteEntityAsync(Guid tankId)
    {
        try
        {
            var entity = dbSet.FirstOrDefault(a => a.Id.Equals(tankId));
            if (entity is not null)
            {
                dbSet.Remove(entity);
                await dbContext.SaveChangesAsync();
                return true;
            }
            return false;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public async Task<T> EditEntityAsync(T entity)
    {
        var reulst = dbSet.Update(entity);
        await dbContext.SaveChangesAsync();
        return reulst.Entity;
    }

    public T GetById(Guid fishId)
    {
        return dbSet.Find(fishId);
    }

    public async Task<IList<T>> GetListAsync()
    {
        return await dbSet.ToListAsync();
    }
}
