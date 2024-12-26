using FoodOrderApp.Data;
using FoodOrderApp.Enum;
using FoodOrderApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodOrderApp.Services
{
    public class MenuService(AppDbContext dbContext) : IMenuService
    {
        private readonly AppDbContext _dbContext = dbContext;

        public List<MenuItem> GetMenuItems()
        {
            return _dbContext.MenuItems
                .AsNoTracking()
                .OrderBy(i => i.Category)
                .ToList();
        }

        public List<MenuItem> GetMenuItemsByCategory(Category category)
        {
            return _dbContext.MenuItems
                .AsNoTracking()
                .Where(i => i.Category == category)
                .ToList();
        }

        public MenuItem? GetMenuItem(int id)
        {
            return _dbContext.MenuItems.AsNoTracking().FirstOrDefault(i => i.Id == id);
        }

        public void AddMenuItem(MenuItem item)
        {
            _dbContext.MenuItems.Add(item);
            _dbContext.SaveChanges();
        }

        public void UpdateMenuItem(MenuItem item)
        {
            var existingItem = _dbContext.MenuItems.FirstOrDefault(i => i.Id == item.Id);
            if (existingItem == null) return;
            
            existingItem.Name = item.Name;
            existingItem.Price = item.Price;
            existingItem.Description = existingItem.Description;
            existingItem.Category = item.Category;
            existingItem.ImageUrl = existingItem.ImageUrl;
            existingItem.IsAvailable = existingItem.IsAvailable;
            
            _dbContext.MenuItems.Update(existingItem);
            _dbContext.SaveChanges();
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
