using Catalog.Data.Entities;

namespace Catalog.Data.Abstract
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProductsAsync();
        Task<Product> GetProductByIdAsync(string id);
        Task<IEnumerable<Product>> GetProductByNameAsync(string name);
        Task<IEnumerable<Product>> GetProductsByCategoryAsync(string categoryName);

        Task CreateProuctAsync(Product product);
        Task<bool> UpdateProductAsync(Product product);
        Task<bool> DeleteProductAsync(string id);
    }
}
