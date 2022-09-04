using AbstractFactoryRestaurant.Recipes;

namespace AbstractFactoryRestaurant.Factories
{
    internal class SummerRecipeFactory : IRecipeFactory
    {
        public IRecipe Create(Country country)
        {
            return country switch
            {
                Country.England => new EnglishSummerRecipe(),
                Country.Ukraine => new UkranianSummerRecipe(),
                Country.India => new IndianSummerRecipe(),
                _ => throw new InvalidOperationException()
            };
        }
    }
}
