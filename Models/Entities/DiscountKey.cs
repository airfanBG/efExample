using Models.Contracts;

namespace Models.Entities;

public class DiscountKey:BaseEntity
{
    public string Key { get; set; }
    public decimal Discount { get; set; }
    public string OrderId { get; set; }
    public Order Order { get; set; }
}