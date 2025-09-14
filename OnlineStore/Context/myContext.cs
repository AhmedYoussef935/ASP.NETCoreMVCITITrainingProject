using Microsoft.EntityFrameworkCore;
using OnlineStore.Models;
using System.Collections.Generic;

namespace OnlineStore.Context
{
    public class myContext: DbContext
    {
        // Connect To Database
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=localdb;Database=OnlineStore;Trusted_Connection=True;TrustServerCertificate=True";
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Fluent API
            ICollection<User> users = new List<User>
            {
                new User { UserId = 1, FirstName = "John", LastName = "Smith", Email = "john.smith@example.com" },
                new User { UserId = 2, FirstName = "Emily", LastName = "Johnson", Email = "emily.johnson@example.com" },
                new User { UserId = 3, FirstName = "Michael", LastName = "Brown", Email = "michael.brown@example.com" },
                new User { UserId = 4, FirstName = "Sarah", LastName = "Williams", Email = "sarah.williams@example.com" },
                new User { UserId = 5, FirstName = "David", LastName = "Jones", Email = "david.jones@example.com", },
                new User { UserId = 6, FirstName = "Olivia", LastName = "Miller", Email = "olivia.miller@example.com", },
                new User { UserId = 7, FirstName = "Daniel", LastName = "Davis", Email = "daniel.davis@example.com", },
                new User { UserId = 8, FirstName = "Sophia", LastName = "Garcia", Email = "sophia.garcia@example.com", },
                new User { UserId = 9, FirstName = "James", LastName = "Martinez", Email = "james.martinez@example.com", },
                new User { UserId = 10, FirstName = "Isabella", LastName = "Hernandez", Email = "isabella.hernandez@example.com" },
                new User { UserId = 11, FirstName = "William", LastName = "Lopez", Email = "william.lopez@example.com" },
                new User { UserId = 12, FirstName = "Mia", LastName = "Gonzalez", Email = "mia.gonzalez@example.com" },
                new User { UserId = 13, FirstName = "Benjamin", LastName = "Wilson", Email = "benjamin.wilson@example.com" },
                new User { UserId = 14, FirstName = "Charlotte", LastName = "Anderson", Email = "charlotte.anderson@example.com" },
                new User { UserId = 15, FirstName = "Ethan", LastName = "Thomas", Email = "ethan.thomas@example.com" },
                new User { UserId = 16, FirstName = "Amelia", LastName = "Taylor", Email = "amelia.taylor@example.com" },
                new User { UserId = 17, FirstName = "Alexander", LastName = "Moore", Email = "alexander.moore@example.com" },
                new User { UserId = 18, FirstName = "Harper", LastName = "Jackson", Email = "harper.jackson@example.com" },
                new User { UserId = 19, FirstName = "Henry", LastName = "Martin", Email = "henry.martin@example.com" },
                new User { UserId = 20, FirstName = "Evelyn", LastName = "Lee", Email = "evelyn.lee@example.com" },
                new User { UserId = 21, FirstName = "Matthew", LastName = "Perez", Email = "matthew.perez@example.com" },
                new User { UserId = 22, FirstName = "Ella", LastName = "Thompson", Email = "ella.thompson@example.com" },
                new User { UserId = 23, FirstName = "Samuel", LastName = "White", Email = "samuel.white@example.com" },
                new User { UserId = 24, FirstName = "Abigail", LastName = "Harris", Email = "abigail.harris@example.com" },
                new User { UserId = 25, FirstName = "Joseph", LastName = "Sanchez", Email = "joseph.sanchez@example.com" },
                new User { UserId = 26, FirstName = "Scarlett", LastName = "Clark", Email = "scarlett.clark@example.com" },
                new User { UserId = 27, FirstName = "Christopher", LastName = "Ramirez", Email = "christopher.ramirez@example.com" },
                new User { UserId = 28, FirstName = "Grace", LastName = "Lewis", Email = "grace.lewis@example.com" },
                new User { UserId = 29, FirstName = "Andrew", LastName = "Robinson", Email = "andrew.robinson@example.com" },
                new User { UserId = 30, FirstName = "Chloe", LastName = "Walker", Email = "chloe.walker@example.com" }
            };
            ICollection<Category> categories = new List<Category>
            {
                new Category { CategoryId = 1, CategoryName = "Apple", CategoryDescription = "Newest iPhones" },
                new Category { CategoryId = 2, CategoryName = "Samsung", CategoryDescription = "Latest Samsung Galaxy Phones" },
                new Category { CategoryId = 3, CategoryName = "Xiaomi", CategoryDescription = "Flagship & current Xiaomi phones" },
                new Category { CategoryId = 4, CategoryName = "OPPO", CategoryDescription = "Latest and flagship OPPO phones" },
                new Category { CategoryId = 5, CategoryName = "Honor", CategoryDescription = "New Honor smartphones" }
            };
            ICollection<Product> products = new List<Product>
            {
                // Apple
                new Product { ProductId = 1, Title = "iPhone 17 Pro Max", Price = 1399, Description = "Apple 2025 flagship, best camera & performance", Quantity = 50, CategoryId = 1, ImagePath = "https://cdn.shortpixel.ai/spai/q_glossy+ret_img+to_webp/mobizil.com/wp-content/uploads/2025/09/iPhone-17-Pro-Max2.jpg" },
                new Product { ProductId = 2, Title = "iPhone 17 Pro", Price = 1299, Description = "High-end with Pro features", Quantity = 60, CategoryId = 1, ImagePath = "https://cdn.shortpixel.ai/spai/q_glossy+ret_img+to_webp/mobizil.com/wp-content/uploads/2025/09/iPhone-17-Pro2.jpg" },
                new Product { ProductId = 3, Title = "iPhone 17", Price = 999, Description = "Standard flagship", Quantity = 70, CategoryId = 1, ImagePath = "https://cdn.shortpixel.ai/spai/q_glossy+ret_img+to_webp/mobizil.com/wp-content/uploads/2025/09/iPhone-17.jpg" },
                new Product { ProductId = 4, Title = "iPhone Air", Price = 1099, Description = "New ultra-thin iPhone Air design", Quantity = 55, CategoryId = 1, ImagePath = "https://cdn.shortpixel.ai/spai/q_glossy+ret_img+to_webp/mobizil.com/wp-content/uploads/2025/09/iPhone-Air.jpg" },
                new Product { ProductId = 5, Title = "iPhone 16e", Price = 799, Description = "Mid-range Apple, compact size", Quantity = 80, CategoryId = 1, ImagePath = "https://cdn.shortpixel.ai/spai/q_glossy+ret_img+to_webp/mobizil.com/wp-content/uploads/2025/02/Apple-iPhone-16e.jpg" },
                new Product { ProductId = 6, Title = "iPhone 16 Pro", Price = 1199, Description = "Previous generation Pro", Quantity = 40, CategoryId = 1, ImagePath = "https://cdn.shortpixel.ai/spai/q_glossy+ret_img+to_webp/mobizil.com/wp-content/uploads/2024/09/iphone-16-pro-2.jpg" },
                new Product { ProductId = 7, Title = "iPhone 16", Price = 899, Description = "Previous generation standard", Quantity = 65, CategoryId = 1, ImagePath = "https://cdn.shortpixel.ai/spai/q_glossy+ret_img+to_webp/mobizil.com/wp-content/uploads/2024/09/iPhone-16-1.jpg" },

                // Samsung
                new Product { ProductId = 8, Title = "Samsung Galaxy S25 Ultra", Price = 1399, Description = "Samsung top-flagship 2025", Quantity = 30, CategoryId = 2, ImagePath = "https://cdn.shortpixel.ai/spai/q_glossy+ret_img+to_webp/mobizil.com/wp-content/uploads/2025/01/Samsung-Galaxy-S25-Ultra-5G.jpg" },
                new Product { ProductId = 9, Title = "Samsung Galaxy S25+", Price = 1199, Description = "S25 plus model", Quantity = 45, CategoryId = 2, ImagePath = "https://cdn.shortpixel.ai/spai/q_glossy+ret_img+to_webp/mobizil.com/wp-content/uploads/2025/01/Samsung-Galaxy-S25-Plus-5G.jpg" },
                new Product { ProductId = 10, Title = "Samsung Galaxy S25", Price = 999, Description = "Base S25 model", Quantity = 60, CategoryId = 2, ImagePath = "https://cdn.shortpixel.ai/spai/q_glossy+ret_img+to_webp/mobizil.com/wp-content/uploads/2025/01/Samsung-Galaxy-S23-5G.jpg" },
                new Product { ProductId = 11, Title = "Samsung Galaxy Z Fold 7", Price = 1899, Description = "Foldable premium", Quantity = 20, CategoryId = 2, ImagePath = "https://cdn.shortpixel.ai/spai/q_glossy+ret_img+to_webp/mobizil.com/wp-content/uploads/2025/07/Samsung-Galaxy-Z-Fold7-3.jpg" },
                new Product { ProductId = 12, Title = "Samsung Galaxy Z Flip 6", Price = 1299, Description = "Foldable (flip style)", Quantity = 25, CategoryId = 2, ImagePath = "https://cdn.shortpixel.ai/spai/q_glossy+ret_img+to_webp/mobizil.com/wp-content/uploads/2024/07/samsung-galaxy-z-fold6.jpg" },
                new Product { ProductId = 13, Title = "Samsung Galaxy A55 5G", Price = 499, Description = "Mid-range A-series", Quantity = 100, CategoryId = 2, ImagePath = "https://cdn.shortpixel.ai/spai/q_glossy+ret_img+to_webp/mobizil.com/wp-content/uploads/2024/03/Samsung-Galaxy-A55-2.jpg" },
                new Product { ProductId = 14, Title = "Samsung Galaxy A35 5G", Price = 399, Description = "More affordable mid-range", Quantity = 120, CategoryId = 2, ImagePath = "https://cdn.shortpixel.ai/spai/q_glossy+ret_img+to_webp/mobizil.com/wp-content/uploads/2024/03/Samsung-Galaxy-A35-1.jpg" },

                // Xiaomi
                new Product { ProductId = 15, Title = "Xiaomi 15 Ultra", Price = 1299, Description = "Xiaomi top flagship 2025", Quantity = 35, CategoryId = 3, ImagePath = "https://i02.appmifile.com/492_operatorx_operatorx_opx/02/03/2025/5667c36c15d47b90d0faa7ac23c9f276.png?f=webp" },
                new Product { ProductId = 16, Title = "Xiaomi 15", Price = 1099, Description = "Standard flagship version", Quantity = 50, CategoryId = 3, ImagePath = "https://i02.appmifile.com/339_operatorx_operatorx_opx/02/03/2025/73371d9d0ca9843bcab6875541dc2905.png?thumb=1&w=1000&f=webp&q=85" },
                new Product { ProductId = 17, Title = "Xiaomi Mix Flip", Price = 1399, Description = "Foldable Flip", Quantity = 20, CategoryId = 3, ImagePath = "https://i02.appmifile.com/562_operatorx_operatorx_opx/26/09/2024/dbd8ab2e47beb33c1e0b9aa96287b35c.png?thumb=1&w=1000&f=webp&q=85" },
                new Product { ProductId = 18, Title = "Xiaomi 14 Ultra", Price = 1199, Description = "Prior Ultra model, still strong", Quantity = 40, CategoryId = 3, ImagePath = "https://i02.appmifile.com/91_operatorx_operatorx_opx/24/02/2024/4eafcd40186edde466860564f9ff71e9.png?thumb=1&w=600&f=webp&q=85" },
                new Product { ProductId = 19, Title = "Xiaomi POCO F7 Ultra", Price = 699, Description = "Value / performance-oriented", Quantity = 80, CategoryId = 3, ImagePath = "https://i02.appmifile.com/602_operatorx_operatorx_opx/27/03/2025/7f55fcb97ad2db5405139b5c6b241d20.png?thumb=1&w=600&f=webp&q=85" },
                new Product { ProductId = 20, Title = "Redmi Note 14 Pro", Price = 499, Description = "High mid-range Redmi", Quantity = 90, CategoryId = 3, ImagePath = "https://i02.appmifile.com/177_operatorx_operatorx_opx/10/01/2025/9e49d2cf6f1afe7ab8255aef590af500.png?thumb=1&w=1000&f=webp&q=85" },
                new Product { ProductId = 21, Title = "Xiaomi 14", Price = 999, Description = "Flagship just before 15 series", Quantity = 45, CategoryId = 3, ImagePath = "https://i02.appmifile.com/976_operatorx_operatorx_opx/23/02/2024/c4866f7bdd20c6ed7acf6082417dd340.png?thumb=1&w=600&f=webp&q=85" },

                // OPPO
                new Product { ProductId = 22, Title = "OPPO Find X8 Ultra", Price = 1399, Description = "Flagship ultra camera set", Quantity = 30, CategoryId = 4, ImagePath = "https://www.oppo.com/content/dam/oppo/common/mkt/v2-2/find-x8-series-en/find-x8-pro/listpage/432-600-black.png" },
                new Product { ProductId = 23, Title = "OPPO Find X8 Pro", Price = 1299, Description = "Pro performance", Quantity = 35, CategoryId = 4 , ImagePath = "https://www.oppo.com/content/dam/oppo/common/mkt/v2-2/find-x8-series-en/find-x8-pro/listpage/432-600-white.png"},
                new Product { ProductId = 24, Title = "OPPO Find X8", Price = 1099, Description = "More accessible flagship", Quantity = 50, CategoryId = 4 , ImagePath = "https://www.oppo.com/content/dam/oppo/common/mkt/v2-2/find-x8-series-en/find-x8/listpage/436-600-white-v2.png"},
                new Product { ProductId = 25, Title = "OPPO Reno 14 Pro 5G", Price = 899, Description = "Premium mid-range Reno series", Quantity = 60, CategoryId = 4 , ImagePath = "https://www.oppo.com/content/dam/oppo/common/mkt/v2-2/reno14-series/list-page/reno14-pro/448-600-white.png"},
                new Product { ProductId = 26, Title = "OPPO Reno 14 5G", Price = 699, Description = "Mid-range Reno", Quantity = 80, CategoryId = 4 , ImagePath = "https://www.oppo.com/content/dam/oppo/common/mkt/v2-2/reno14-series/list-page/reno14/448-600-green.png"},
                new Product { ProductId = 27, Title = "OPPO Find N5", Price = 1499, Description = "Foldable premium", Quantity = 15, CategoryId = 4 , ImagePath = "https://www.oppo.com/content/dam/oppo/common/mkt/v2-2/oppo-find-n5-en/listpage/427-600-white.png"},
                new Product { ProductId = 28, Title = "OPPO Reno 13 Pro 5G", Price = 799, Description = "Value mid-high", Quantity = 90, CategoryId = 4 , ImagePath = "https://www.oppo.com/content/dam/oppo/common/mkt/v2-2/reno13-series/list-page/reno13-pro-5g/purple.png"},

                // Honor
                new Product { ProductId = 29, Title = "Honor Magic 7 Pro", Price = 1199, Description = "Honor flagship, Snapdragon 8 Elite", Quantity = 30, CategoryId = 5 , ImagePath = "https://www.honor.com/content/dam/honor/common/product-list/product-series/honor-magic7/honor-magic7-id-white-back.png"},
                new Product { ProductId = 30, Title = "Honor Magic V5", Price = 1599, Description = "Foldable from Honor", Quantity = 20, CategoryId = 5 , ImagePath = "https://www.honor.com/content/dam/honor/common/product-list/product-series/honor-magic-v5/honor-magic-v5-id-gold.png"},
                new Product { ProductId = 31, Title = "Honor 400 Pro", Price = 599, Description = "Mid-range strong offering", Quantity = 60, CategoryId = 5 , ImagePath = "https://www.honor.com/content/dam/honor/common/product-list/product-series/honor-400-pro/honor-400-pro-id-gary-back.png"},
                new Product { ProductId = 32, Title = "Honor Magic 6 Pro", Price = 1099, Description = "Earlier flagship", Quantity = 25, CategoryId = 5 , ImagePath = "https://www.honor.com/content/dam/honor/common/product-list/product-series/honor-magic6-pro/honor-magic6-pro-id-green-back.png"},
                new Product { ProductId = 33, Title = "Honor X9c 5G", Price = 499, Description = "Upper mid-range", Quantity = 80, CategoryId = 5 , ImagePath = "https://www.honor.com/content/dam/honor/common/product-list/product-series/honor-x9c-smart/honor-x9c-smart-cyan-back.png"},
                new Product { ProductId = 34, Title = "Honor 90 GT", Price = 699, Description = "Gaming style mid-range", Quantity = 40, CategoryId = 5 , ImagePath = "https://www.honor.com/content/dam/honor/common/product-list/product-series/honor-90-lite/honor-90-lite-lake-back.png"},
                new Product { ProductId = 35, Title = "Honor Magic 7 Lite", Price = 499, Description = "Value / budget-mid", Quantity = 90, CategoryId = 5 , ImagePath = "https://www.honor.com/content/dam/honor/common/product-list/product-series/honor-magic7/honor-magic7-id-black-front.png"}
            };
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Products)
                .WithOne(p => p.Category)
                .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<User>()
                .HasData(users);
            modelBuilder.Entity<Category>()
                .HasData(categories);
            modelBuilder.Entity<Product>()
                .HasData(products);
            base.OnModelCreating(modelBuilder);
        }
        // Tables
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
    }
}
