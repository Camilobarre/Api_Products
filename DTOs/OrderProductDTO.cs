namespace Api_Products.DTOs
{
    public class OrderProductDto
    {
        public int ProductId { get; set; } // ID del producto
        public string? ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }

}