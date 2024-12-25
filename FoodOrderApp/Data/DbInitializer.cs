using FoodOrderApp.Enum;
using FoodOrderApp.Models;

namespace FoodOrderApp.Data
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext dbContext)
        {
            dbContext.MenuItems.AddRange(
                new MenuItem
                {
                    Id = 1,
                    Name = "Cheeseburger",
                    Description = "Classic beef burger with cheese",
                    Price = 9.99m,
                    Category = Category.Burgers,
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/4d/Cheeseburger.jpg",
                    IsAvailable = true
                },
                new MenuItem
                {
                    Id = 2,
                    Name = "French Fries",
                    Description = "Crispy golden fries",
                    Price = 4.99m,
                    Category = Category.Sides,
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/4d/Cheeseburger.jpg",
                    IsAvailable = true
                },
                new MenuItem
                {
                    Id = 3,
                    Name = "Chocolate Shake",
                    Description = "Rich and creamy shake",
                    Price = 5.99m,
                    Category = Category.Drinks,
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/4d/Cheeseburger.jpg",
                    IsAvailable = true
                },
                new MenuItem
                {
                    Id = 4,
                    Name = "Double Bacon Burger",
                    Description = "Double patty with crispy bacon and special sauce",
                    Price = 12.99m,
                    Category = Category.Burgers,
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/4d/Cheeseburger.jpg",
                    IsAvailable = true
                },
                new MenuItem
                {
                    Id = 5,
                    Name = "Mushroom Swiss Burger",
                    Description = "Plant-based patty with grilled mushrooms and Swiss cheese",
                    Price = 10.99m,
                    Category = Category.Vegetarian,
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/4d/Cheeseburger.jpg",
                    IsAvailable = true
                },
                new MenuItem
                {
                    Id = 6,
                    Name = "Onion Rings",
                    Description = "Beer-battered crispy onion rings",
                    Price = 5.99m,
                    Category = Category.Sides,
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/4d/Cheeseburger.jpg",
                    IsAvailable = true
                },
                new MenuItem
                {
                    Id = 7,
                    Name = "Apple Pie",
                    Description = "Warm apple pie with vanilla ice cream",
                    Price = 6.99m,
                    Category = Category.Desserts,
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/4d/Cheeseburger.jpg",
                    IsAvailable = true
                },
                new MenuItem
                {
                    Id = 8,
                    Name = "Chocolate Brownie",
                    Description = "Rich chocolate brownie with whipped cream",
                    Price = 5.99m,
                    Category = Category.Desserts,
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/4d/Cheeseburger.jpg",
                    IsAvailable = true
                },
                new MenuItem
                {
                    Id = 9,
                    Name = "Lemonade",
                    Description = "Fresh squeezed lemonade with mint",
                    Price = 3.99m,
                    Category = Category.Drinks,
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/4d/Cheeseburger.jpg",
                    IsAvailable = true
                },
                new MenuItem
                {
                    Id = 10,
                    Name = "Veggie Wrap",
                    Description = "Fresh vegetables with hummus in a whole wheat wrap",
                    Price = 8.99m,
                    Category = Category.Vegetarian,
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/4d/Cheeseburger.jpg",
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
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/4/4d/Cheeseburger.jpg",
                    IsAvailable = true
                }
            );

            dbContext.SaveChanges();
        }
    }
}
