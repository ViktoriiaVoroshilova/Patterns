namespace AbstractFactoryRestaurant.Recipes
{
    internal class EnglishSummerRecipe : IRecipe
    {
        public int ChickenAmount { get => 50; }
        public Level ChickenFryLevel { get => Level.Low; }
        public Level ChickenSaltLevel { get => Level.Zero; }
        public Level ChickenPepperLevel { get => Level.Zero; }
        public int RiceAmount { get => 50; }
        public Level RiceFryLevel { get => Level.Low; }
        public Level RiceSaltLevel { get => Level.Zero; }
        public Level RicePepperLevel { get => Level.Zero; }
    }
}