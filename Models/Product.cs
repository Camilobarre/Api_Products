namespace Api_Products.Models
{
    public class Product
    {
        public int Id { get; set; } // Primary Key
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        // Foreign key de Category
        public int CategoryId { get; set; }
        public Category? Category { get; set; } // Navegación de relación
    }

}