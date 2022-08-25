namespace AbstractFactoryRestaurant.Factories
{
    internal interface ISeasonFactory
    {
        public IRecipeFactory Create(DateTime dateTime);
    }
}
