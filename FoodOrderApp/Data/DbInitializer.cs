using FoodOrderApp.Enum;
using FoodOrderApp.Models;

namespace FoodOrderApp.Data
{
    public static class DbInitializer
    {
        public static async Task Seed(AppDbContext dbContext)
        {
            if (dbContext.MenuItems.Any())
            {
                return;
            }
            
            await dbContext.MenuItems.AddRangeAsync(
                new MenuItem
                {
                    Id = 1,
                    Name = "Cheeseburger",
                    Description = "Classic beef burger with cheese",
                    Price = 9.99m,
                    Category = Category.Burgers,
                    ImageUrl = "https://images.pexels.com/photos/14678738/pexels-photo-14678738.jpeg",
                    NutritionalInfo = NutritionalData.Cheeseburger,
                    IsAvailable = true
                },
                new MenuItem
                {
                    Id = 2,
                    Name = "French Fries",
                    Description = "Crispy golden fries",
                    Price = 4.99m,
                    Category = Category.Sides,
                    ImageUrl = "https://images.pexels.com/photos/1583884/pexels-photo-1583884.jpeg",
                    NutritionalInfo = NutritionalData.FrenchFries,
                    IsAvailable = true
                },
                new MenuItem
                {
                    Id = 3,
                    Name = "Chocolate Shake",
                    Description = "Rich and creamy shake",
                    Price = 5.99m,
                    Category = Category.Drinks,
                    ImageUrl = "https://images.pexels.com/photos/3727250/pexels-photo-3727250.jpeg",
                    NutritionalInfo = NutritionalData.ChocolateShake,
                    IsAvailable = true
                },
                new MenuItem
                {
                    Id = 4,
                    Name = "Double Bacon Burger",
                    Description = "Double patty with crispy bacon and special sauce",
                    Price = 12.99m,
                    Category = Category.Burgers,
                    ImageUrl = "https://images.pexels.com/photos/3052362/pexels-photo-3052362.jpeg",
                    NutritionalInfo = NutritionalData.DoubleBaconBurger,
                    IsAvailable = true
                },
                new MenuItem
                {
                    Id = 5,
                    Name = "Mushroom Swiss Burger",
                    Description = "Plant-based patty with grilled mushrooms and Swiss cheese",
                    Price = 10.99m,
                    Category = Category.Vegetarian,
                    ImageUrl = "https://images.pexels.com/photos/2874989/pexels-photo-2874989.jpeg",
                    NutritionalInfo = NutritionalData.MushroomSwissBurger,
                    IsAvailable = true
                },
                new MenuItem
                {
                    Id = 6,
                    Name = "Onion Rings",
                    Description = "Beer-battered crispy onion rings",
                    Price = 5.99m,
                    Category = Category.Sides,
                    ImageUrl = "https://images.pexels.com/photos/6036950/pexels-photo-6036950.jpeg",
                    NutritionalInfo = NutritionalData.OnionRings,
                    IsAvailable = true
                },
                new MenuItem
                {
                    Id = 7,
                    Name = "Apple Pie",
                    Description = "Warm apple pie with vanilla ice cream",
                    Price = 6.99m,
                    Category = Category.Desserts,
                    ImageUrl = "https://images.pexels.com/photos/2957897/pexels-photo-2957897.jpeg",
                    NutritionalInfo = NutritionalData.ApplePie,
                    IsAvailable = true
                },
                new MenuItem
                {
                    Id = 8,
                    Name = "Chocolate Brownie",
                    Description = "Rich chocolate brownie with whipped cream",
                    Price = 5.99m,
                    Category = Category.Desserts,
                    ImageUrl = "https://images.pexels.com/photos/2067396/pexels-photo-2067396.jpeg",
                    NutritionalInfo = NutritionalData.ChocolateBrownie,
                    IsAvailable = true
                },
                new MenuItem
                {
                    Id = 9,
                    Name = "Lemonade",
                    Description = "Fresh squeezed lemonade with mint",
                    Price = 3.99m,
                    Category = Category.Drinks,
                    ImageUrl = "https://images.pexels.com/photos/2109099/pexels-photo-2109099.jpeg",
                    NutritionalInfo = NutritionalData.Lemonade,
                    IsAvailable = true
                },
                new MenuItem
                {
                    Id = 10,
                    Name = "Veggie Wrap",
                    Description = "Fresh vegetables with hummus in a whole wheat wrap",
                    Price = 8.99m,
                    Category = Category.Vegetarian,
                    ImageUrl = "https://images.pexels.com/photos/2955819/pexels-photo-2955819.jpeg",
                    NutritionalInfo = NutritionalData.VeggieWrap,
                    IsAvailable = true
                },
                new MenuItem
                {
                    Id = 11,
                    Name = "Blazing Combo Deal",
                    Description = "Treat yourself to our signature Blazing Combo, " +
                                "featuring a juicy beef patty topped with melted cheese and our secret spicy sauce. " +
                                "Includes crispy medium fries and your choice of refreshing drink!",
                    Price = 12.99m,
                    Category = Category.ComboDeal,
                    ImageUrl = "https://images.pexels.com/photos/2983101/pexels-photo-2983101.jpeg",
                    NutritionalInfo = NutritionalData.BlazingComboDeal,
                    IsAvailable = true
                }
            );

            await dbContext.SaveChangesAsync();
        }
    }
}
