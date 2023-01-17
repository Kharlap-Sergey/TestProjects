using System.Text.Json;
using Basket.Data.Entities;
using Basket.Data.Repositories;
using Microsoft.Extensions.Caching.Distributed;

namespace Basket.Data.Redis
{
    public class BasketRepository : IBasketRepository
    {
        private readonly IDistributedCache _redisCache;

        public BasketRepository(
            IDistributedCache distributedCache
            )
        {
            _redisCache = distributedCache;
        }

        public async Task Delete(string userName)
        {
            await _redisCache.RemoveAsync(userName);
        }

        public async Task<ShoppingCart?> Get(string userName)
        {
            var basket = await _redisCache.GetStringAsync(userName);
            if (String.IsNullOrEmpty(basket))
                return null;

            return JsonSerializer.Deserialize<ShoppingCart>(basket);
        }

        public async Task Update(ShoppingCart basket)
        {
            await _redisCache.SetStringAsync(basket.UserName, JsonSerializer.Serialize(basket));
        }
    }
}