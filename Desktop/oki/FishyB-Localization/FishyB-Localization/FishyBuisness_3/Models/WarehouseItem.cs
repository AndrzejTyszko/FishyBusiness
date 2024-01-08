namespace FishyBuisness_3.Models
{
    public class WarehouseItem
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int WarehouseId { get; set; }
        public int Quantity { get; set; }

        // Klucz obcy do modelu Product
        public Product Product { get; set; }

        // Klucz obcy do modelu Warehouse
        public Warehouse Warehouse { get; set; }
    }
}
