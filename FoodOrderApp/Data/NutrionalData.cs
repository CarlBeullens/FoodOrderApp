using FoodOrderApp.Models;

namespace FoodOrderApp.Data;

public static class NutritionalData
{
   public static NutritionalInfo Cheeseburger => new()
   {
       Calories = 650,
       TotalFat = 35,
       SaturatedFat = 13,
       TransFat = 1.5,
       Cholesterol = 85,
       Sodium = 1200,
       Carbohydrates = 49,
       Fiber = 2,
       Sugar = 9,
       Protein = 32
   };

   public static NutritionalInfo FrenchFries => new()
   {
       Calories = 380,
       TotalFat = 17,
       SaturatedFat = 2.5,
       TransFat = 0,
       Cholesterol = 0,
       Sodium = 480,
       Carbohydrates = 53,
       Fiber = 5,
       Sugar = 0,
       Protein = 4
   };

   public static NutritionalInfo ChocolateShake => new()
   {
       Calories = 590,
       TotalFat = 13,
       SaturatedFat = 8,
       TransFat = 0.5,
       Cholesterol = 50,
       Sodium = 420,
       Carbohydrates = 98,
       Fiber = 2,
       Sugar = 84,
       Protein = 12
   };

   public static NutritionalInfo DoubleBaconBurger => new()
   {
       Calories = 920,
       TotalFat = 52,
       SaturatedFat = 20,
       TransFat = 2,
       Cholesterol = 145,
       Sodium = 1680,
       Carbohydrates = 51,
       Fiber = 2,
       Sugar = 11,
       Protein = 58
   };

   public static NutritionalInfo MushroomSwissBurger => new()
   {
       Calories = 580,
       TotalFat = 28,
       SaturatedFat = 10,
       TransFat = 0,
       Cholesterol = 45,
       Sodium = 980,
       Carbohydrates = 56,
       Fiber = 8,
       Sugar = 6,
       Protein = 25
   };

   public static NutritionalInfo OnionRings => new()
   {
       Calories = 410,
       TotalFat = 22,
       SaturatedFat = 4,
       TransFat = 0,
       Cholesterol = 0,
       Sodium = 640,
       Carbohydrates = 48,
       Fiber = 3,
       Sugar = 6,
       Protein = 5
   };

   public static NutritionalInfo ApplePie => new()
   {
       Calories = 340,
       TotalFat = 17,
       SaturatedFat = 8,
       TransFat = 0,
       Cholesterol = 20,
       Sodium = 300,
       Carbohydrates = 45,
       Fiber = 2,
       Sugar = 25,
       Protein = 3
   };

   public static NutritionalInfo ChocolateBrownie => new()
   {
       Calories = 420,
       TotalFat = 22,
       SaturatedFat = 12,
       TransFat = 0,
       Cholesterol = 55,
       Sodium = 320,
       Carbohydrates = 52,
       Fiber = 3,
       Sugar = 35,
       Protein = 6
   };

   public static NutritionalInfo Lemonade => new()
   {
       Calories = 160,
       TotalFat = 0,
       SaturatedFat = 0,
       TransFat = 0,
       Cholesterol = 0,
       Sodium = 10,
       Carbohydrates = 42,
       Fiber = 0,
       Sugar = 40,
       Protein = 0
   };

   public static NutritionalInfo VeggieWrap => new()
   {
       Calories = 420,
       TotalFat = 18,
       SaturatedFat = 4,
       TransFat = 0,
       Cholesterol = 0,
       Sodium = 860,
       Carbohydrates = 56,
       Fiber = 8,
       Sugar = 4,
       Protein = 12
   };

   public static NutritionalInfo BlazingComboDeal => new()
   {
       Calories = 1250,
       TotalFat = 62,
       SaturatedFat = 22,
       TransFat = 1.5,
       Cholesterol = 95,
       Sodium = 1880,
       Carbohydrates = 132,
       Fiber = 7,
       Sugar = 42,
       Protein = 45
   };
}