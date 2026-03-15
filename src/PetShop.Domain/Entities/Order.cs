using PetShop.Domain.Commom;

namespace PetShop.Domain.Entities;

public class Order : BaseEntity
{
    public Guid OrderId { get; private set; } 
    
    public DateTime OrderDate  { get; private set; }
    
    public decimal TotalAmount  { get; private set; }
    
    public Guid CustomerId { get; private set; }
    
    // public Costumer Costumer { get; private set; }
    
    
    // Relacionamento N:1 e 1:N
    // Order N:1 Customer
    // Order 1:N OrderItem

    public Order(Guid orderId, DateTime orderDate, decimal totalAmount)
    {
        OrderId = orderId;
        OrderDate = orderDate;
        TotalAmount = totalAmount;
    }
}