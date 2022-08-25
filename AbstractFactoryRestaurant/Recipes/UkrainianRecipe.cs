namespace AbstractFactoryRestaurant.Recipes
{
    internal class UkranianRecipe : IRecipe
    {
        public int ChickenAmount { get => 300; }
        public Level ChickenFryLevel { get => Level.Medium; }
        public Level ChickenSaltLevel { get => Level.Medium; }
        public Level ChickenPepperLevel { get => Level.Low; }
        public int RiceAmount { get => 500; }
        public Level RiceFryLevel { get => Level.Strong; }
        public Level RiceSaltLevel { get => Level.Strong; }
        public Level RicePepperLevel { get => Level.Low; }
    }
}