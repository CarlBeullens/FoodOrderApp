using FoodOrderApp.Enum;

namespace FoodOrderApp.Models
{
    public class MenuItem
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public Category Category { get; set; }
        public string ImageUrl { get; set; } = "https://placehold.co/400";
        public NutritionalInfo NutritionalInfo { get; set; } = new();
        public bool IsAvailable { get; set; }
    }
}
