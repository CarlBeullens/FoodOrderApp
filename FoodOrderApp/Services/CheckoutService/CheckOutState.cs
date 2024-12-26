using FoodOrderApp.Models;
using FoodOrderApp.Services.CartService;

namespace FoodOrderApp.Services.CheckoutService;

public class CheckOutState
{
    public List<CartItem> CartItems { get; set; } = new();
    public CartCalculation CartCalculation { get; set; } = new();
}