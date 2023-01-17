using Basket.Data.Entities;

namespace Basket.Data.Repositories
{
    public interface IBasketRepository
    {
        Task<ShoppingCart?> Get(string userName);

        Task Update(ShoppingCart basket);

        Task Delete(string userName);
    }
}
