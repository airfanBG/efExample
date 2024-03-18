using Models.Contracts;

namespace Models.Entities;

public class Order:BaseEntity
{
    public DateTime CreatedAt { get; set; }
    public decimal Total { get; set; }
    public string UserId { get; set; }
    public User User { get; set; }
   
}