namespace Api_Products.Models
{
public class Order
{
    public int Id { get; set; } // Primary Key
    public DateTime OrderDate { get; set; }

    // Información del cliente
    public string? CustomerName { get; set; }
    public string? CustomerAddress { get; set; }
    public string? CustomerContact { get; set; }

    // Relación con Product
    public ICollection<OrderProduct>? OrderProducts { get; set; } // Un pedido puede tener varios productos
}

}