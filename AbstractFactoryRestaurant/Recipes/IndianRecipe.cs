namespace AbstractFactoryRestaurant.Recipes
{
    internal class IndianRecipe : IRecipe
    {
        public int ChickenAmount { get => 100; }
        public Level ChickenFryLevel { get => Level.Strong; }
        public Level ChickenSaltLevel { get => Level.Strong; }
        public Level ChickenPepperLevel { get => Level.Strong; }
        public int RiceAmount { get => 200; }
        public Level RiceFryLevel { get => Level.Strong; }
        public Level RiceSaltLevel { get => Level.Strong; }
        public Level RicePepperLevel { get => Level.Strong; }
    }
}