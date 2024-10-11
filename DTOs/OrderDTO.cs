namespace Api_Products.DTOs
{
    public class OrderDto
    {
        public int Id { get; set; } // Primary Key
        public DateTime OrderDate { get; set; }
        public string? CustomerName { get; set; }
        public string? CustomerAddress { get; set; }
        public string? CustomerContact { get; set; }
        public List<OrderProductDto>? Products { get; set; } // Lista de productos del pedido
    }

}