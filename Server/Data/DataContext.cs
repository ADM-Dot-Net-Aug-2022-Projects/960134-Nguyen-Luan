namespace Hoalu.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CartItem>()
                .HasKey(ci => new { ci.UserId, ci.ProductId, ci.ProductTypeId });

            modelBuilder.Entity<ProductVariant>()
                .HasKey(p => new { p.ProductId, p.ProductTypeId });

            modelBuilder.Entity<OrderItem>()
                .HasKey(oi => new { oi.OrderId, oi.ProductId, oi.ProductTypeId });

            modelBuilder.Entity<ProductType>().HasData(
                    new ProductType { Id = 1, Name = "Mini" },
                    new ProductType { Id = 2, Name = "Regular" },
                    new ProductType { Id = 3, Name = "Large" }
                );

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Flowers",
                    Url = "flowers"
                },
                new Category
                {
                    Id = 2,
                    Name = "Plants",
                    Url = "plants"
                }
                );

            modelBuilder.Entity<Product>().HasData(
                    new Product
                    {
                        Id = 1,
                        Title = "Red Rose Bouquet",
                        Description = "Blooming with bright colors to boldly express your every emotion, this exquisite flower bouquet is set to celebrate. Hot pink roses, purple Peruvian lilies, lavender mini carnations, green hypericum berries, lily grass blades and lush greens are brought together to create an incredible flower arrangement. Presented in a clear glass cube vase, this mixed flower bouquet will make that perfect impression on a birthday, anniversary, or as a way to extend your congratulations or thank you wishes.",
                        ImageUrl = "https://cdn.azflorist.com/wp-content/uploads/20220405121236/C15-4949D.jpg",
                        CategoryId = 1,
                        Featured = true
                    },
                    new Product
                    {
                        Id = 2,
                        Title = "Pink Lily Bouquet",
                        Description = "This sweet bouquet is an expression of your love and affection. Fragrant pink Stargazer lilies are accented with pink statice and arranged in a clear glass vase. Send it for birthday, anniversary, get well, or just because you care.",
                        ImageUrl = "https://cdn.azflorist.com/wp-content/uploads/20220405122001/S22-4298S.jpg",
                        CategoryId = 1
                    },
                    new Product
                    {
                        Id = 3,
                        Title = "Sunset Bouquet",
                        Description = "Pink Lilies make the eyes dance across the unique design of this flower bouquet, surrounded by the blushing colors of orange roses, lavender cushion poms, hot pink carnations, and lush greens. Presented in a clear glass vase, this fresh flower arrangement has been created just for you to help you send your sweetest thank you, happy anniversary, or thinking of you wishes.",
                        ImageUrl = "https://cdn.azflorist.com/wp-content/uploads/20220405123118/C5375D.png",
                        CategoryId = 1
                    },
                    new Product
                    {
                        Id = 4,
                        Title = "The Pure Clouds",
                        Description = "Our local florists handcraft a stunning display of lilies, roses and other elegant florals to delight them for any and every occasion.",
                        ImageUrl = "https://cdn.azflorist.com/wp-content/uploads/20220524092019/CHAD.jpeg",
                        CategoryId = 1,
                        Featured = true
                    },
                    new Product
                    {
                        Id = 5,
                        Title = "Moonstruck Bouquet",
                        Description = "For that superstar in your life, treat them to something so gorgeous, it’s out of this world. Designed by a local florist, the Moonstruck Bouquet comes with a refreshing mix of white florals and arrives in style right to their doorstep.",
                        ImageUrl = "https://cdn.azflorist.com/wp-content/uploads/20220524101105/PGQP.png",
                        CategoryId = 1,
                        Featured = true
                    },
                    new Product
                    {
                        Id = 6,
                        CategoryId = 1,
                        Title = "Sunflower Bouquet",
                        Description = "Stunning sunflowers are mixed with glossy magnolia leaves for a dramatic, day-brightening delivery.",
                        ImageUrl = "https://image.floranext.com/instances/theflowercart_org/catalog/product/y/o/youregoldenbouquetbyteleflora_1.jpg?w=308&h=308&gen=1",

                    },
                    new Product
                    {
                        Id = 7,
                        Title = "Blue Orchid",
                        Description = "Beautiful dyed Blue Orchid plant, Perfect for someone who loves blue, new baby boy or a special man in your life!",
                        ImageUrl = "https://fyf.tac-cdn.net/images/products/large/P-149.jpg?auto=webp&quality=60&width=690",
                        CategoryId = 2,

                    },
                    new Product
                    {
                        Id = 8,
                        Title = "Cactus Garden",
                        Description = "Enjoy the southwest with this prickly but beautiful cactus garden.",
                        ImageUrl = "https://www.treehugger.com/thmb/VpYez07ecRrO4et_DV080D30ErA=/735x0/__opt__aboutcom__coeus__resources__content_migration__mnn__images__2017__09__SucculentsRoundGardenTrayInFrontOfBench-b92233aff63940f8a4ea98981ab98d1d.jpg",
                        CategoryId = 2,
                    },
                    new Product
                    {
                        Id = 9,
                        Title = "White Orchid",
                        Description = "The striking Phalaenopsis orchid makes a graceful tribute to loved ones who have passed on. Tastefully set by our florists in a classic glass cube planter, its vibrant green leaves and wing-shaped white blooms are a thoughtful gesture of sympathy when delivered to the home of friends and family.",
                        ImageUrl = "https://cdn.shopify.com/s/files/1/0150/6262/products/the-sill_white-orchid_bryant_black_variant.jpg?v=1658772624",
                        CategoryId = 2,
                    },
                    new Product
                    {
                        Id = 10,
                        Title = "Succelent Garden",
                        Description = "Like a best friend, this unique garden of fresh green succulents is adaptable, low-maintenance, and a great addition to any setting.",
                        ImageUrl = "https://www.bhg.com/thmb/Bsu_svLq5LOM8AvgUgFyDDwb4cg=/1866x1050/smart/filters:no_upscale():focal(1006x509:1008x511)/mini-succulent-container-663ff722-8f8200d7ec4341bea48bc9e4df5d33dc.jpg",
                        CategoryId = 2,
                    },
                    new Product
                    {
                        Id = 11,
                        Title = "Sansevieria Snake Plant",
                        Description = "The sansevieria or snake plant, features naturalistic river grass and an organic shape. These trendy baskets add style and character to a living room or bedroom. The neutral color and texture fits perfectly in a variety of home settings.\r\nSansevieria is one of the top air purifying plants identified by NASA, removing at least 108 known air pollutants. It is also one of the few plants that releases oxygen during the night.",
                        ImageUrl = "https://images.costco-static.com/ImageDelivery/imageService?profileId=12026540&imageId=1327184-847__1&recipeName=350",
                        CategoryId = 2,
                    }
                    );

            modelBuilder.Entity<ProductVariant>().HasData(
                new ProductVariant
                {
                    ProductId = 1,
                    ProductTypeId = 1,
                    Price = 19.99m,
                },
                new ProductVariant
                {
                    ProductId = 1,
                    ProductTypeId = 2,
                    Price = 29.99m
                },
                new ProductVariant
                {
                    ProductId = 1,
                    ProductTypeId = 3,
                    Price = 39.99m,
                },
                new ProductVariant
                {
                    ProductId = 2,
                    ProductTypeId = 1,
                    Price = 19.99m,
                },
                new ProductVariant
                {
                    ProductId = 2,
                    ProductTypeId = 2,
                    Price = 29.99m
                },
                new ProductVariant
                {
                    ProductId = 2,
                    ProductTypeId = 3,
                    Price = 39.99m,
                },
                new ProductVariant
                {
                    ProductId = 3,
                    ProductTypeId = 2,
                    Price = 49.99m
                },
                new ProductVariant
                {
                    ProductId = 3,
                    ProductTypeId = 3,
                    Price = 69.99m,
                },
                new ProductVariant
                {
                    ProductId = 4,
                    ProductTypeId = 2,
                    Price = 49.99m
                },
                new ProductVariant
                {
                    ProductId = 4,
                    ProductTypeId = 3,
                    Price = 69.99m,
                },
                new ProductVariant
                {
                    ProductId = 5,
                    ProductTypeId = 1,
                    Price = 25.99m,
                },
                new ProductVariant
                {
                    ProductId = 5,
                    ProductTypeId = 2,
                    Price = 35.99m
                },
                new ProductVariant
                {
                    ProductId = 6,
                    ProductTypeId = 1,
                    Price = 45.99m
                },
                new ProductVariant
                {
                    ProductId = 6,
                    ProductTypeId = 2,
                    Price = 55.99m
                },
                new ProductVariant
                {
                    ProductId = 7,
                    ProductTypeId = 2,
                    Price = 35.99m
                },
                new ProductVariant
                {
                    ProductId = 8,
                    ProductTypeId = 1,
                    Price = 15.99m
                },
                new ProductVariant
                {
                    ProductId = 9,
                    ProductTypeId = 2,
                    Price = 35.99m
                },
                new ProductVariant
                {
                    ProductId = 10,
                    ProductTypeId = 1,
                    Price = 15.99m
                },
                new ProductVariant
                {
                    ProductId = 11,
                    ProductTypeId = 3,
                    Price = 45.99m
                }
            );
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<ProductVariant> ProductVariants { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Image> Images { get; set; }
    }
}
