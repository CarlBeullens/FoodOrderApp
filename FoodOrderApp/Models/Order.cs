using FoodOrderApp.Enum;

namespace FoodOrderApp.Models
{
    public class Order
    {
        public int Id { get; set; }
        public List<OrderItem> Items { get; set; } = new();
        public decimal TotalAmount => Items.Sum(item => item.Quantity * item.MenuItem.Price);
        public DateTime OrderTime { get; set; }
        public OrderStatus Status { get; set; }
    }
}
