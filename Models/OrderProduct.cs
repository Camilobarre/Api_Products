namespace Api_Products.Models
{
    public class OrderProduct
    {
        public int OrderId { get; set; } // Foreign Key de Order
        public Order? Order { get; set; } // Navegación de relación

        public int ProductId { get; set; } // Foreign Key de Product
        public Product? Product { get; set; } // Navegación de relación

        public int Quantity { get; set; } // Cantidad de productos en el pedido
    }

}