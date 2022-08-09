using ProductCatalogService.Models;

namespace ProductCatalogService
{
    public interface IProductCatalog
    {
        Product GetProductDetails(string productId);
    }
}
