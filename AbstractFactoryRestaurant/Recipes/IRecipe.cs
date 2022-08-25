namespace AbstractFactoryRestaurant.Recipes
{
    internal interface IRecipe
    {
        public int ChickenAmount { get; }

        public Level ChickenFryLevel { get; }

        public Level ChickenSaltLevel { get; }

        public Level ChickenPepperLevel { get; }

        public int RiceAmount { get; }

        public Level RiceFryLevel { get; }

        public Level RiceSaltLevel { get; }

        public Level RicePepperLevel { get; }
    }
}
