namespace MVCWebApp.Models
{
    public class Basket
    {
        public string BuyerId { get; set; }
        public List<BasketItem> Items { get; set; }

        public decimal Total()
        {
            return Math.Round(Items.Sum(x => x.UnitPrice * x.Quantity), 2);
        }
    }
}
