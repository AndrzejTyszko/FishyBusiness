namespace FishyBuisness_3.Models
{
    public class FishTank
    {
        public int FishTankId { get; set; }
        public string Name { get; set; }
        public string Descirption { get; set; }
        public int Capacity { get; set; }
        public int EnvironmentId {  get; set; }

        public Environment? Environment{ get; set; }
    }
}
