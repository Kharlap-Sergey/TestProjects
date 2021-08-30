using Microsoft.AspNetCore.Mvc;
using RestFullApi.Domain;

namespace RestfullApi.Api.Controllers
{
    [Route( "api/[controller]" )]
    [ApiController]
    public class QuoteController : ControllerBase
    {
        private readonly ApiDbContext _apiDbContext;

        public QuoteController(
                ApiDbContext apiDbContext
            )
        {
           this. _apiDbContext = apiDbContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var quotes = this._apiDbContext.Quotes;
            return Ok(quotes);
        }
    }
}
