using FoodOrderApp.Models;

namespace FoodOrderApp.Services
{
    public class CartService : ICartService
    {
        private List<CartItem> _cartItems = new List<CartItem>();
        public event Action? OnCartChanged;

        public List<CartItem> GetCartItems() 
        {
            return _cartItems;
        }

        public void AddToCart(MenuItem menuItem, int quantity = 1)
        {
            var existingItem = _cartItems.FirstOrDefault(x => x.MenuItem.Id == menuItem.Id);

            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
            }

            else
            {
                _cartItems.Add(new CartItem
                {
                    MenuItem = menuItem,
                    Quantity = quantity
                });
            }

            UpdateCartState();
        }

        public void RemoveFromCart(MenuItem menuItem)
        {
            var itemToRemove = _cartItems.FirstOrDefault(x => x.MenuItem.Id == menuItem.Id);
            
            if (itemToRemove != null)
            {
                _cartItems.Remove(itemToRemove);
                UpdateCartState();
            }
        }

        public void IncreaseQuantity(MenuItem menuItem)
        {
            var item = _cartItems.FirstOrDefault(x => x.MenuItem.Id == menuItem.Id);

            if (item != null)
            {
                item.Quantity++;
                UpdateCartState();
            }
        }

        public void DecreaseQuantity(MenuItem menuItem)
        {
            var item = _cartItems.FirstOrDefault(x => x.MenuItem.Id == menuItem.Id);

            if (item == null) return;

            if (item.Quantity > 1)
            {
                item.Quantity--;
                UpdateCartState();
            }
        }

        public void ClearCart()
        {
            _cartItems.Clear();
            UpdateCartState();
        }

        public int GetCartItemCount()
        {
            return _cartItems.Sum(item => item.Quantity);
        }

        private void UpdateCartState()
        {
            OnCartChanged?.Invoke();
        }
    }
}
