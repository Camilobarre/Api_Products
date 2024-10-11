namespace Api_Products.DTOs
{
    public class ProductDto
    {
        public int Id { get; set; } // Primary Key
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
    }

}