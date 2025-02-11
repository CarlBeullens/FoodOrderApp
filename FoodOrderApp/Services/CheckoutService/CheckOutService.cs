using FoodOrderApp.Models;
using FoodOrderApp.Services.CartService;
using Stripe;
using Stripe.Checkout;

namespace FoodOrderApp.Services.CheckoutService;

public class CheckOutService(IConfiguration configuration) : ICheckoutService
{
    public CheckOutState State { get; set; } = new();

    public async Task<string> CreateCheckoutSession(List<CartItem> cartItems, CartCalculation calculation, string successUrl, string cancelUrl)
    {
        InitializeStripe();
        
        var lineItems = new List<SessionLineItemOptions>();

        // Add all cart items
        lineItems.AddRange(cartItems.Select(item => new SessionLineItemOptions
        {
            PriceData = new SessionLineItemPriceDataOptions
            {
                Currency = "eur",
                ProductData = new SessionLineItemPriceDataProductDataOptions
                {
                    Name = item.MenuItem.Name
                },
                UnitAmount = (long)(item.MenuItem.Price * 100)
            },
            Quantity = item.Quantity
        }));

        // Add discount if applicable
        if (calculation.HasDiscount)
        {
            lineItems.Add(new SessionLineItemOptions
            {
                PriceData = new SessionLineItemPriceDataOptions
                {
                    Currency = "eur",
                    ProductData = new SessionLineItemPriceDataProductDataOptions
                    {
                        Name = "Discount (10%)"
                    },
                    UnitAmount = (long)(-calculation.Discount * 100)
                },
                Quantity = 1
            });
        }

        // Add delivery fee if not free
        if (!calculation.HasFreeDelivery)
        {
            lineItems.Add(new SessionLineItemOptions
            {
                PriceData = new SessionLineItemPriceDataOptions
                {
                    Currency = "eur",
                    ProductData = new SessionLineItemPriceDataProductDataOptions
                    {
                        Name = "Delivery Fee"
                    },
                    UnitAmount = (long)(calculation.DeliveryFee * 100)
                },
                Quantity = 1
            });
        }

        var options = new SessionCreateOptions
        {
            PaymentMethodTypes = new List<string> { "card" },
            LineItems = lineItems,
            Mode = "payment",
            SuccessUrl = successUrl,
            CancelUrl = cancelUrl
        };

        var service = new SessionService();
        var session = await service.CreateAsync(options);

        return session.Url;
    }
    
    private void InitializeStripe()
    {
        var apiKey = GetStripeApiKey(configuration);
        StripeConfiguration.ApiKey = apiKey;
    }
    
    private static string GetStripeApiKey(IConfiguration configuration)
    {
        var encodedKey = configuration["Stripe:DecodedSecretKey"] ?? throw new InvalidOperationException("Stripe:DecodedSecretKey not found in configuration");
        byte[] data = Convert.FromBase64String(encodedKey);
        return System.Text.Encoding.UTF8.GetString(data);
    }
}