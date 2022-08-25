using AbstractFactoryRestaurant.Recipes;

namespace AbstractFactoryRestaurant.Factories
{
    internal interface IRecipeFactory
    {
        IRecipe Create(Country country);
    }
}
