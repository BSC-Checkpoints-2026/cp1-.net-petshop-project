using PetShop.Domain.Commom;

namespace PetShop.Domain.Entities;

public class Service : BaseEntity
{
    public Guid ServiceId { get; private set; } 
    
    public string Name { get; private set; }
    
    public string Description { get; private set; }
    
    public decimal Price { get; private set; }
    
    public int DurationInMinutes { get; private set; }
    
    
    // Relacionamentos 1:N:
    // Service 1:N Appointment

    public Service(Guid serviceId, string name, string description, decimal price, int durationInMinutes)
    {
        ServiceId = serviceId;
        Name = name;
        Description = description;
        Price = price;
        DurationInMinutes = durationInMinutes;
    }
}