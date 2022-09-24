namespace ShoppingBasket.API.Domain
{
    public class Basket
    {
        public string BuyerId { get; set; }
        public List<BasketItem> Items { get; set; }
    }
}
