using FoodOrderApp.Models;
using FoodOrderApp.Services.CartService;

namespace FoodOrderApp.Services.CheckoutService;

public interface ICheckoutService
{
    CheckOutState State { get; set; }

    Task<string> CreateCheckoutSession(List<CartItem> cartItems, CartCalculation calculation, string successUrl, string cancelUrl);
}