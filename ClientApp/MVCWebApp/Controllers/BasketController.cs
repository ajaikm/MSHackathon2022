using Microsoft.AspNetCore.Mvc;
using MVCWebApp.Models;
using MVCWebApp.Services;

namespace MVCWebApp.Controllers
{
    public class BasketController : Controller
    {
        IBasketService _basketService;
        ICatalogService _catalogService;

        public BasketController(IBasketService basketService, ICatalogService catalogService)
        {
            _basketService = basketService;
            _catalogService = catalogService;
        }

        public async Task<IActionResult> Index()
        {
            var userId = "DemoUser";
            var basket = await _basketService.GetBasket(userId);
            return View(basket);

        }

        public async Task<IActionResult> AddToBasket(int id)
        {
            CatalogItem catItem = await _catalogService.GetItemDetails(id);
            if (catItem != null)
            {
                var userId = "DemoUser";
                var product = new BasketItem()
                {
                    Id = Guid.NewGuid().ToString(),
                    Quantity = 1,
                    ProductName = catItem.Name,
                    //PictureUrl = catItem.PictureUrl,
                    UnitPrice = catItem.Price,
                    ProductId = Convert.ToInt32(catItem.Id)
                };
                await _basketService.AddItemToBasket(userId, product);
            }
            return RedirectToAction("Index", "Catalog");

        }
    }
}
