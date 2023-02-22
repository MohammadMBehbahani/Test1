namespace FishManagement_Domain_Tests.Entities_Tests.Fish_Tests
{
    internal class Fish
    {
        private string fishType;
        private double fishFoodWeight;

        public Fish(string fishType, double fishFoodWeight)
        {
            this.fishType = fishType;
            this.fishFoodWeight = fishFoodWeight;
        }
    }
}