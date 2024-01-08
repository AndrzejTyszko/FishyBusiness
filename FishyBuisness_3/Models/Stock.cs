namespace FishyBuisness_3.Models
{
    public class Stock
    {
        public int StockId { get; set; }
        public int FishId { get; set; }
        public int FishTankId { get; set; }
        public int Quantity { get; set; }
        public int EnvironmentId {  get; set; }

        // Klucz obcy do modelu Product
        public Fish Fish { get; set; }

        // Klucz obcy do modelu Warehouse
        public FishTank FishTank { get; set; }

        public Environment Environment { get; set; }

    }

}
