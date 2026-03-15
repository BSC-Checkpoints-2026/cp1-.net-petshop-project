using PetShop.Domain.Commom;

namespace PetShop.Domain.Entities;

public class OrderItem : BaseEntity
{
    
    public int Quantity { get; private set; }
    
    public decimal UnitPrice { get; private set; }
    
    public Guid OrderId { get; private set; }
    
    public Guid ProductId {get; private set;}
    
    // Relacionamentos N:1
    //public Order Order { get; private set; }
    
    //public Product Product {get; private set;}
    
    // Construtor

    public OrderItem(int quantity, decimal unitPrice, Guid orderId, Guid productId)
    {
        Quantity = quantity;
        UnitPrice = unitPrice;
        OrderId = orderId;
        ProductId = productId;
    }
}