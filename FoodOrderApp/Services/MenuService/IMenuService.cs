using FoodOrderApp.Enum;
using FoodOrderApp.Models;

namespace FoodOrderApp.Services.MenuService
{
    public interface IMenuService
    {
        List<MenuItem> GetMenuItems();
        List<MenuItem> GetMenuItemsByCategory(Category category);
        MenuItem? GetMenuItem(int id);
        void AddMenuItem(MenuItem item);
        void UpdateMenuItem(MenuItem item);
        void DeleteMenuItem(int id);
    }
}
