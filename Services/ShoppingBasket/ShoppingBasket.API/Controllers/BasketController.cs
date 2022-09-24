using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingBasket.API.Domain;
using ShoppingBasket.API.Repository;
using System.Net;

namespace ShoppingBasket.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketController : ControllerBase
    {
        private IBasketRepository _repository;
        public BasketController(IBasketRepository repository)
        {
            _repository = repository;
        }

        // GET basket/5
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Basket), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> Get(string id)
        {
            var basket = await _repository.GetBasketAsync(id);
            return Ok(basket);
        }

        // POST basket
        [HttpPost]
        [ProducesResponseType(typeof(Basket), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> Post([FromBody] Basket value)
        {
            var basket = await _repository.UpdateBasketAsync(value);
            return Ok(basket);
        }

        // DELETE bakset/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _repository.DeleteBasketAsync(id);
        }

    }
}
