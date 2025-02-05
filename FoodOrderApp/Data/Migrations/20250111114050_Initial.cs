using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoodOrderApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MenuItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(8,2)", nullable: false),
                    Category = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: false),
                    NutritionalInfo_Calories = table.Column<double>(type: "float", nullable: false),
                    NutritionalInfo_TotalFat = table.Column<double>(type: "float", nullable: false),
                    NutritionalInfo_SaturatedFat = table.Column<double>(type: "float", nullable: false),
                    NutritionalInfo_TransFat = table.Column<double>(type: "float", nullable: false),
                    NutritionalInfo_Cholesterol = table.Column<double>(type: "float", nullable: false),
                    NutritionalInfo_Sodium = table.Column<double>(type: "float", nullable: false),
                    NutritionalInfo_Carbohydrates = table.Column<double>(type: "float", nullable: false),
                    NutritionalInfo_Fiber = table.Column<double>(type: "float", nullable: false),
                    NutritionalInfo_Sugar = table.Column<double>(type: "float", nullable: false),
                    NutritionalInfo_Protein = table.Column<double>(type: "float", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItems", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MenuItems");
        }
    }
}
