namespace Api_Products.Models
{
    public class Category
    {
        public int Id { get; set; } // Primary Key
        public string? Name { get; set; }
        public string? Description { get; set; }

        // Relación con Product
        public ICollection<Product>? Products { get; set; } // Una categoría tiene muchos productos
    }

}