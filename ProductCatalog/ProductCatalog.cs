using AutoFixture;
using ProductCatalogService.Models;

namespace ProductCatalogService
{
    public class ProductCatalog : IProductCatalog
    {
        public Product GetProductDetails(string productId)
        {
            Console.WriteLine($"Getting details about product {productId}");
            var fixture = new Fixture();

            return fixture
                .Build<Product>()
                .With(x => x.Id, productId)
                .Create();
        }
    }
}
