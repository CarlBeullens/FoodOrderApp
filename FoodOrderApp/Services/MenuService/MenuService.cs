using FoodOrderApp.Data;
using FoodOrderApp.Enum;
using FoodOrderApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;

namespace FoodOrderApp.Services.MenuService
{
    public class MenuService : IMenuService
    {
        private readonly AppDbContext _dbContext;
        private readonly IMemoryCache _cache;

        public MenuService(IMemoryCache cache, AppDbContext dbContext)
        {
            _cache = cache;
            _dbContext = dbContext;
        }
        
        public List<MenuItem> GetMenuItems()
        {
            var items = _cache.Get<List<MenuItem>>("MenuItems");
            
            if (items == null)
            {
                items = _dbContext.MenuItems
                    .AsNoTracking()
                    .OrderBy(i => i.Category)
                    .ToList();

                _cache.Set("MenuItems", items, TimeSpan.FromHours(1));
            }

            return items;
        }

        public List<MenuItem> GetMenuItemsByCategory(Category category)
        {
            var items = _cache.Get<List<MenuItem>>($"MenuItem_{category}");

            if (items == null)
            {
                return _dbContext.MenuItems
                    .AsNoTracking()
                    .Where(i => i.Category == category)
                    .ToList();
            }
            
            return items;
        }

        public MenuItem? GetMenuItem(int id)
        {
            var item = _cache.Get<MenuItem?>($"MenuItem_{id}");

            if (item == null)
            {
                return _dbContext.MenuItems.AsNoTracking().FirstOrDefault(i => i.Id == id);
            }

            return item;
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
