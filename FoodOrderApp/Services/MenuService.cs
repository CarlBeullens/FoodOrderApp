using FoodOrderApp.Data;
using FoodOrderApp.Enum;
using FoodOrderApp.Models;

namespace FoodOrderApp.Services
{
    public class MenuService(AppDbContext dbContext) : IMenuService
    {
        private readonly AppDbContext _dbContext = dbContext;

        public List<MenuItem> GetMenuItems()
        {
            return _dbContext.MenuItems
                .OrderBy(i => i.Category)
                .ToList();
        }

        public List<MenuItem> GetMenuItemsByCategory(Category category)
        {
            return _dbContext.MenuItems
                .Where(i => i.Category == category)
                .ToList();
        }

        public MenuItem? GetMenuItem(int id)
        {
            return _dbContext.MenuItems.FirstOrDefault(i => i.Id == id);
        }

        public void AddMenuItem(MenuItem item)
        {
            _dbContext.MenuItems.Add(item);
            _dbContext.SaveChanges();
        }

        public void UpdateMenuItem(MenuItem item)
        {
            var existingItem = _dbContext.MenuItems.FirstOrDefault(i => i.Id == item.Id);
            if (existingItem != null)
            {
                _dbContext.MenuItems.Update(existingItem);
                _dbContext.SaveChanges();
            }
        }

        public void DeleteMenuItem(int id)
        {
            var item = _dbContext.MenuItems.FirstOrDefault(i => i.Id == id);
            if (item != null)
            {
                _dbContext.MenuItems.Remove(item);
                _dbContext.SaveChanges();
            }
        }
    }
}
