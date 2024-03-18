using Models.Contracts;

namespace Models.Entities;

public class Employee:BaseEntity,IUser
{
    public string Username { get; set; }
    public string Email { get; set; }
}