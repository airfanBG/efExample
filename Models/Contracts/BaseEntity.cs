namespace Models.Contracts;

public class BaseEntity:IEntity
{
    public BaseEntity()
    {
        Id = Guid.NewGuid().ToString();
    }
    public string Id { get; set; }
}