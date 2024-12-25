using FoodOrderApp.Models;

namespace FoodOrderApp.Services
{
    public interface ICartService
    {
        event Action? OnCartChanged;
        List<CartItem> GetCartItems();
        void AddToCart(MenuItem menuItem, int quantity = 1);
        void RemoveFromCart(MenuItem menuItem);
        void IncreaseQuantity(MenuItem menuItem);
        void DecreaseQuantity(MenuItem menuItem);
        void ClearCart();
        int GetCartItemCount();
    }
}
