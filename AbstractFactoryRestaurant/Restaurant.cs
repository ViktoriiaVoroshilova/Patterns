using AbstractFactoryRestaurant.Factories;
using AbstractFactoryRestaurant.Recipes;
using Microsoft.Extensions.Logging;

namespace AbstractFactoryRestaurant
{
    internal class Restaurant : IRestaurant
    {
        public Restaurant(ISeasonFactory seasonFactory)
        {
            _seasonFactory = seasonFactory;
        }

        public void CookMasala(ICooker cooker, Country country, DateTime dateTime)
        {
            var recipeFactory = _seasonFactory.Create(dateTime);
            var recipeMasala = recipeFactory.Create(country);

            cooker.FryRice(recipeMasala.RiceAmount, recipeMasala.RiceFryLevel);
            cooker.FryChicken(recipeMasala.ChickenAmount, recipeMasala.ChickenFryLevel);
            cooker.SaltChicken(recipeMasala.ChickenSaltLevel);
            cooker.SaltRice(recipeMasala.RiceSaltLevel);
            cooker.PepperChicken(recipeMasala.ChickenPepperLevel);
            cooker.PepperRice(recipeMasala.RicePepperLevel);
        }

        private readonly ISeasonFactory _seasonFactory;
    }
}
