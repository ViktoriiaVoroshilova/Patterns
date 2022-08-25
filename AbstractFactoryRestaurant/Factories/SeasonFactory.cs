namespace AbstractFactoryRestaurant.Factories
{
    internal class SeasonFactory : ISeasonFactory
    {
        public IRecipeFactory Create(DateTime dateTime)
        {
            var month = dateTime.Month;
            if (month >= summerStartMonth && month <= summerEndMonth)
            {
                return new SummerRecipeFactory();
            }
            return new BaseRecipeFactory();
        }

        const int summerStartMonth = 6;
        const int summerEndMonth = 8;
    }
}
