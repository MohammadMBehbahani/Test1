namespace FishManagement_Domain.Entities.Common;

public interface IBaseEntity
{
    public Guid Id { get; }
    public DateTime CreatedAt { get; }
    public DateTime ModifiedAt { get; set; }
}
