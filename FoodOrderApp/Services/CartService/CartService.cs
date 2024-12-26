using FoodOrderApp.Models;

namespace FoodOrderApp.Services.CartService
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

        public CartCalculation CalculateCart()
        {
            var subTotal = _cartItems.Sum(item => item.MenuItem.Price * item.Quantity);
            var hasDiscount = subTotal >= 30;
            var hasFreeDelivery = subTotal >= 50;
            var discount = hasDiscount ? subTotal * 0.1m : 0;
            var deliveryFee = hasFreeDelivery ? 0 : 2.99m;
            var total = subTotal - discount + deliveryFee;

            return new CartCalculation
            {
                SubTotal = subTotal,
                HasDiscount = hasDiscount,
                HasFreeDelivery = hasFreeDelivery,
                Discount = discount,
                DeliveryFee = deliveryFee,
                Total = total
            };
        }

        private void UpdateCartState()
        {
            OnCartChanged?.Invoke();
        }
    }
}
