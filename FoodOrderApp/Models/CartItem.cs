namespace FoodOrderApp.Models
{
    public class CartItem
    {
        public required MenuItem MenuItem { get; set; }
        public required int Quantity { get; set; }
    }
}
