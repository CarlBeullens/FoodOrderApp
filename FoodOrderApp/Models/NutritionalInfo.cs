using Microsoft.EntityFrameworkCore;

namespace FoodOrderApp.Models;

[Owned]
public class NutritionalInfo
{
    public double Calories { get; set; }
    public double TotalFat { get; set; }
    public double SaturatedFat { get; set; }
    public double TransFat { get; set; }
    public double Cholesterol { get; set; }
    public double Sodium { get; set; }
    public double Carbohydrates { get; set; }
    public double Fiber { get; set; }
    public double Sugar { get; set; }
    public double Protein { get; set; }
}