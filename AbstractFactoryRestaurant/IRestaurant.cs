namespace AbstractFactoryRestaurant
{
    internal interface IRestaurant
    {
        public void CookMasala(ICooker cooker, Country country, DateTime dateTime);
    }
}
