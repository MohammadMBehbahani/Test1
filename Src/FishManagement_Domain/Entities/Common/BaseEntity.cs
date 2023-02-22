namespace FishManagement_Domain.Entities.Common;

public class BaseEntity : IBaseEntity
{
    public DateTime CreatedAt { get; private set; } = DateTime.UtcNow;
    public DateTime ModifiedAt { get; set; } = DateTime.UtcNow;
    public Guid Id { get;private set; }

    public BaseEntity()
    {
        this.Id = Guid.NewGuid();
    }
}
