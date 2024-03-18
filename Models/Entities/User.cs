using Models.Contracts;

namespace Models.Entities;

public class User:BaseEntity,IUser
{
    public string Username { get; set; }
    public IList<Order> Orders { get; set; }
}