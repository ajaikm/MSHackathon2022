using ShoppingBasket.API.Domain;

namespace ShoppingBasket.API.Repository
{
    public interface IBasketRepository
    {
        Task<Basket> GetBasketAsync(string buyerId);
        IEnumerable<string> GetBuyers();
        Task<Basket> UpdateBasketAsync(Basket basket);
        Task<bool> DeleteBasketAsync(string buyerId);

    }
}
