using AbstractFactoryRestaurant.Recipes;

namespace AbstractFactoryRestaurant.Factories
{
    internal class BaseRecipeFactory : IRecipeFactory
    {
        public IRecipe Create(Country country)
        {
            return country switch
            {
                Country.England => new EnglishRecipe(),
                Country.Ukraine => new UkranianRecipe(),
                Country.India => new IndianRecipe(),
                _ => throw new InvalidOperationException()
            };
        }
    }
}
