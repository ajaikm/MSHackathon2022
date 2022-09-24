using MVCWebApp.Models;

namespace MVCWebApp.Services
{
    public interface IBasketService
    {
        Task<Basket> GetBasket(string userId);
        Task AddItemToBasket(string userId, BasketItem product);
        Task<Basket> UpdateBasket(Basket basket);
        Task ClearBasket(string userId);

    }
}
