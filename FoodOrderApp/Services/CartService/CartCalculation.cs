namespace FoodOrderApp.Services.CartService;

public class CartCalculation
{
    public decimal SubTotal { get; init; }
    public bool HasDiscount { get; init; }
    public bool HasFreeDelivery { get; init; }
    public decimal Discount { get; init; }
    public decimal DeliveryFee { get; init; }
    public decimal Total { get; init; }
}