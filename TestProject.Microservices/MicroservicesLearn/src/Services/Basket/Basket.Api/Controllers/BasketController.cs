using Basket.Data.Entities;
using Basket.Data.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Basket.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketController : ControllerBase
    {
        private readonly IBasketRepository _basketRepository;

        public BasketController(
            IBasketRepository basketRepository
            )
        {
            _basketRepository = basketRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get(string userName)
        {
            var basket = await  _basketRepository.Get(userName);
            return Ok(basket ?? new ShoppingCart(userName));
        }

        [HttpPost]
        public async Task<IActionResult> Update(ShoppingCart basket)
        {
            await _basketRepository.Update(basket);
            return Ok(basket);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(string userName)
        {
            await _basketRepository.Delete(userName);
            return Ok();
        }

        [HttpPost("checkout")]
        public async Task<IActionResult> CHeckout()
        {
            return Ok();
        }
    }
}
