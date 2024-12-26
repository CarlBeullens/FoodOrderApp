namespace FoodOrderApp.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public MenuItem MenuItem { get; set; } = new();
        public int Quantity { get; set; }
    }
}
