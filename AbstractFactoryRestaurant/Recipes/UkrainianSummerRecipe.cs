namespace AbstractFactoryRestaurant.Recipes
{
    internal class UkranianSummerRecipe : IRecipe
    {
        public int ChickenAmount { get => 200; }
        public Level ChickenFryLevel { get => Level.Medium; }
        public Level ChickenSaltLevel { get => Level.Low; }
        public Level ChickenPepperLevel { get => Level.Zero; }
        public int RiceAmount { get => 150; }
        public Level RiceFryLevel { get => Level.Medium; }
        public Level RiceSaltLevel { get => Level.Low; }
        public Level RicePepperLevel { get => Level.Zero; }
    }
}