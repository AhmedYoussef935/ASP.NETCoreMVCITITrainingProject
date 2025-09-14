using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnlineStore.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CategoryDescription = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId");
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryDescription", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Newest iPhones", "Apple" },
                    { 2, "Latest Samsung Galaxy Phones", "Samsung" },
                    { 3, "Flagship & current Xiaomi phones", "Xiaomi" },
                    { 4, "Latest and flagship OPPO phones", "OPPO" },
                    { 5, "New Honor smartphones", "Honor" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "FirstName", "LastName", "Password" },
                values: new object[,]
                {
                    { 1, "john.smith@example.com", "John", "Smith", "Pass@123" },
                    { 2, "emily.johnson@example.com", "Emily", "Johnson", "Pass@123" },
                    { 3, "michael.brown@example.com", "Michael", "Brown", "Pass@123" },
                    { 4, "sarah.williams@example.com", "Sarah", "Williams", "Pass@123" },
                    { 5, "david.jones@example.com", "David", "Jones", "Pass@123" },
                    { 6, "olivia.miller@example.com", "Olivia", "Miller", "Pass@123" },
                    { 7, "daniel.davis@example.com", "Daniel", "Davis", "Pass@123" },
                    { 8, "sophia.garcia@example.com", "Sophia", "Garcia", "Pass@123" },
                    { 9, "james.martinez@example.com", "James", "Martinez", "Pass@123" },
                    { 10, "isabella.hernandez@example.com", "Isabella", "Hernandez", "Pass@123" },
                    { 11, "william.lopez@example.com", "William", "Lopez", "Pass@123" },
                    { 12, "mia.gonzalez@example.com", "Mia", "Gonzalez", "Pass@123" },
                    { 13, "benjamin.wilson@example.com", "Benjamin", "Wilson", "Pass@123" },
                    { 14, "charlotte.anderson@example.com", "Charlotte", "Anderson", "Pass@123" },
                    { 15, "ethan.thomas@example.com", "Ethan", "Thomas", "Pass@123" },
                    { 16, "amelia.taylor@example.com", "Amelia", "Taylor", "Pass@123" },
                    { 17, "alexander.moore@example.com", "Alexander", "Moore", "Pass@123" },
                    { 18, "harper.jackson@example.com", "Harper", "Jackson", "Pass@123" },
                    { 19, "henry.martin@example.com", "Henry", "Martin", "Pass@123" },
                    { 20, "evelyn.lee@example.com", "Evelyn", "Lee", "Pass@123" },
                    { 21, "matthew.perez@example.com", "Matthew", "Perez", "Pass@123" },
                    { 22, "ella.thompson@example.com", "Ella", "Thompson", "Pass@123" },
                    { 23, "samuel.white@example.com", "Samuel", "White", "Pass@123" },
                    { 24, "abigail.harris@example.com", "Abigail", "Harris", "Pass@123" },
                    { 25, "joseph.sanchez@example.com", "Joseph", "Sanchez", "Pass@123" },
                    { 26, "scarlett.clark@example.com", "Scarlett", "Clark", "Pass@123" },
                    { 27, "christopher.ramirez@example.com", "Christopher", "Ramirez", "Pass@123" },
                    { 28, "grace.lewis@example.com", "Grace", "Lewis", "Pass@123" },
                    { 29, "andrew.robinson@example.com", "Andrew", "Robinson", "Pass@123" },
                    { 30, "chloe.walker@example.com", "Chloe", "Walker", "Pass@123" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Description", "ImagePath", "Price", "Quantity", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Apple 2025 flagship, best camera & performance", "https://cdn.shortpixel.ai/spai/q_glossy+ret_img+to_webp/mobizil.com/wp-content/uploads/2025/09/iPhone-17-Pro-Max2.jpg", 1399f, 50, "iPhone 17 Pro Max" },
                    { 2, 1, "High-end with Pro features", "https://cdn.shortpixel.ai/spai/q_glossy+ret_img+to_webp/mobizil.com/wp-content/uploads/2025/09/iPhone-17-Pro2.jpg", 1299f, 60, "iPhone 17 Pro" },
                    { 3, 1, "Standard flagship", "https://cdn.shortpixel.ai/spai/q_glossy+ret_img+to_webp/mobizil.com/wp-content/uploads/2025/09/iPhone-17.jpg", 999f, 70, "iPhone 17" },
                    { 4, 1, "New ultra-thin iPhone Air design", "https://cdn.shortpixel.ai/spai/q_glossy+ret_img+to_webp/mobizil.com/wp-content/uploads/2025/09/iPhone-Air.jpg", 1099f, 55, "iPhone Air" },
                    { 5, 1, "Mid-range Apple, compact size", "https://cdn.shortpixel.ai/spai/q_glossy+ret_img+to_webp/mobizil.com/wp-content/uploads/2025/02/Apple-iPhone-16e.jpg", 799f, 80, "iPhone 16e" },
                    { 6, 1, "Previous generation Pro", "https://cdn.shortpixel.ai/spai/q_glossy+ret_img+to_webp/mobizil.com/wp-content/uploads/2024/09/iphone-16-pro-2.jpg", 1199f, 40, "iPhone 16 Pro" },
                    { 7, 1, "Previous generation standard", "https://cdn.shortpixel.ai/spai/q_glossy+ret_img+to_webp/mobizil.com/wp-content/uploads/2024/09/iPhone-16-1.jpg", 899f, 65, "iPhone 16" },
                    { 8, 2, "Samsung top-flagship 2025", "https://cdn.shortpixel.ai/spai/q_glossy+ret_img+to_webp/mobizil.com/wp-content/uploads/2025/01/Samsung-Galaxy-S25-Ultra-5G.jpg", 1399f, 30, "Samsung Galaxy S25 Ultra" },
                    { 9, 2, "S25 plus model", "https://cdn.shortpixel.ai/spai/q_glossy+ret_img+to_webp/mobizil.com/wp-content/uploads/2025/01/Samsung-Galaxy-S25-Plus-5G.jpg", 1199f, 45, "Samsung Galaxy S25+" },
                    { 10, 2, "Base S25 model", "https://cdn.shortpixel.ai/spai/q_glossy+ret_img+to_webp/mobizil.com/wp-content/uploads/2025/01/Samsung-Galaxy-S23-5G.jpg", 999f, 60, "Samsung Galaxy S25" },
                    { 11, 2, "Foldable premium", "https://cdn.shortpixel.ai/spai/q_glossy+ret_img+to_webp/mobizil.com/wp-content/uploads/2025/07/Samsung-Galaxy-Z-Fold7-3.jpg", 1899f, 20, "Samsung Galaxy Z Fold 7" },
                    { 12, 2, "Foldable (flip style)", "https://cdn.shortpixel.ai/spai/q_glossy+ret_img+to_webp/mobizil.com/wp-content/uploads/2024/07/samsung-galaxy-z-fold6.jpg", 1299f, 25, "Samsung Galaxy Z Flip 6" },
                    { 13, 2, "Mid-range A-series", "https://cdn.shortpixel.ai/spai/q_glossy+ret_img+to_webp/mobizil.com/wp-content/uploads/2024/03/Samsung-Galaxy-A55-2.jpg", 499f, 100, "Samsung Galaxy A55 5G" },
                    { 14, 2, "More affordable mid-range", "https://cdn.shortpixel.ai/spai/q_glossy+ret_img+to_webp/mobizil.com/wp-content/uploads/2024/03/Samsung-Galaxy-A35-1.jpg", 399f, 120, "Samsung Galaxy A35 5G" },
                    { 15, 3, "Xiaomi top flagship 2025", "https://i02.appmifile.com/492_operatorx_operatorx_opx/02/03/2025/5667c36c15d47b90d0faa7ac23c9f276.png?f=webp", 1299f, 35, "Xiaomi 15 Ultra" },
                    { 16, 3, "Standard flagship version", "https://i02.appmifile.com/339_operatorx_operatorx_opx/02/03/2025/73371d9d0ca9843bcab6875541dc2905.png?thumb=1&w=1000&f=webp&q=85", 1099f, 50, "Xiaomi 15" },
                    { 17, 3, "Foldable Flip", "https://i02.appmifile.com/562_operatorx_operatorx_opx/26/09/2024/dbd8ab2e47beb33c1e0b9aa96287b35c.png?thumb=1&w=1000&f=webp&q=85", 1399f, 20, "Xiaomi Mix Flip" },
                    { 18, 3, "Prior Ultra model, still strong", "https://i02.appmifile.com/91_operatorx_operatorx_opx/24/02/2024/4eafcd40186edde466860564f9ff71e9.png?thumb=1&w=600&f=webp&q=85", 1199f, 40, "Xiaomi 14 Ultra" },
                    { 19, 3, "Value / performance-oriented", "https://i02.appmifile.com/602_operatorx_operatorx_opx/27/03/2025/7f55fcb97ad2db5405139b5c6b241d20.png?thumb=1&w=600&f=webp&q=85", 699f, 80, "Xiaomi POCO F7 Ultra" },
                    { 20, 3, "High mid-range Redmi", "https://i02.appmifile.com/177_operatorx_operatorx_opx/10/01/2025/9e49d2cf6f1afe7ab8255aef590af500.png?thumb=1&w=1000&f=webp&q=85", 499f, 90, "Redmi Note 14 Pro" },
                    { 21, 3, "Flagship just before 15 series", "https://i02.appmifile.com/976_operatorx_operatorx_opx/23/02/2024/c4866f7bdd20c6ed7acf6082417dd340.png?thumb=1&w=600&f=webp&q=85", 999f, 45, "Xiaomi 14" },
                    { 22, 4, "Flagship ultra camera set", "https://www.oppo.com/content/dam/oppo/common/mkt/v2-2/find-x8-series-en/find-x8-pro/listpage/432-600-black.png", 1399f, 30, "OPPO Find X8 Ultra" },
                    { 23, 4, "Pro performance", "https://www.oppo.com/content/dam/oppo/common/mkt/v2-2/find-x8-series-en/find-x8-pro/listpage/432-600-white.png", 1299f, 35, "OPPO Find X8 Pro" },
                    { 24, 4, "More accessible flagship", "https://www.oppo.com/content/dam/oppo/common/mkt/v2-2/find-x8-series-en/find-x8/listpage/436-600-white-v2.png", 1099f, 50, "OPPO Find X8" },
                    { 25, 4, "Premium mid-range Reno series", "https://www.oppo.com/content/dam/oppo/common/mkt/v2-2/reno14-series/list-page/reno14-pro/448-600-white.png", 899f, 60, "OPPO Reno 14 Pro 5G" },
                    { 26, 4, "Mid-range Reno", "https://www.oppo.com/content/dam/oppo/common/mkt/v2-2/reno14-series/list-page/reno14/448-600-green.png", 699f, 80, "OPPO Reno 14 5G" },
                    { 27, 4, "Foldable premium", "https://www.oppo.com/content/dam/oppo/common/mkt/v2-2/oppo-find-n5-en/listpage/427-600-white.png", 1499f, 15, "OPPO Find N5" },
                    { 28, 4, "Value mid-high", "https://www.oppo.com/content/dam/oppo/common/mkt/v2-2/reno13-series/list-page/reno13-pro-5g/purple.png", 799f, 90, "OPPO Reno 13 Pro 5G" },
                    { 29, 5, "Honor flagship, Snapdragon 8 Elite", "https://www.honor.com/content/dam/honor/common/product-list/product-series/honor-magic7/honor-magic7-id-white-back.png", 1199f, 30, "Honor Magic 7 Pro" },
                    { 30, 5, "Foldable from Honor", "https://www.honor.com/content/dam/honor/common/product-list/product-series/honor-magic-v5/honor-magic-v5-id-gold.png", 1599f, 20, "Honor Magic V5" },
                    { 31, 5, "Mid-range strong offering", "https://www.honor.com/content/dam/honor/common/product-list/product-series/honor-400-pro/honor-400-pro-id-gary-back.png", 599f, 60, "Honor 400 Pro" },
                    { 32, 5, "Earlier flagship", "https://www.honor.com/content/dam/honor/common/product-list/product-series/honor-magic6-pro/honor-magic6-pro-id-green-back.png", 1099f, 25, "Honor Magic 6 Pro" },
                    { 33, 5, "Upper mid-range", "https://www.honor.com/content/dam/honor/common/product-list/product-series/honor-x9c-smart/honor-x9c-smart-cyan-back.png", 499f, 80, "Honor X9c 5G" },
                    { 34, 5, "Gaming style mid-range", "https://www.honor.com/content/dam/honor/common/product-list/product-series/honor-90-lite/honor-90-lite-lake-back.png", 699f, 40, "Honor 90 GT" },
                    { 35, 5, "Value / budget-mid", "https://www.honor.com/content/dam/honor/common/product-list/product-series/honor-magic7/honor-magic7-id-black-front.png", 499f, 90, "Honor Magic 7 Lite" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
