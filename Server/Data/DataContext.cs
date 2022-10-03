namespace Hoalu.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                    new Category
                    {
                        Id = 1,
                        Name = "Wedding",
                        Url = "wedding"
                    },
                    new Category
                    {
                        Id = 2,
                        Name = "Holiday",
                        Url = "holiday"
                    },
                    new Category
                    {
                        Id = 3,
                        Name = "Gifts",
                        Url = "gifts"
                    }
                );
            modelBuilder.Entity<Product>().HasData(
                    new Product
                    {
                        Id = 1,
                        Name = "Red Roses",
                        Description = "Dozen of Red Roses",
                        ImageUrl = "https://res.cloudinary.com/bloomnation/image/upload/c_pad,d_vendor:global:catalog:product:image.png,f_auto,fl_preserve_transparency,q_auto/v1643762539/vendor/7294/catalog/product/4/c/4c829ffbc556ca0e1fee0faaebe6d8d6_31.jpg",
                        Price = 12.99m,
                        CategoryId = 2
                    },
                    new Product
                    {
                        Id = 2,
                        Name = "Orchids",
                        Description = "One Orchid plant with Vase",
                        ImageUrl = "https://www.almanac.com/sites/default/files/styles/large/public/image_nodes/orchid-pot-shutterstock_491195248.jpg?itok=k9XxFA4z",
                        Price = 49.99m,
                        CategoryId = 3
                    },
                    new Product
                    {
                        Id = 3,
                        Name = "Wedding Centerpiece",
                        Description = "Amaze your guests with beautiful centerpieces on your table",
                        ImageUrl = "https://i.pinimg.com/564x/3d/a1/e0/3da1e049cc8b83efe88da727d547d00d--easy-cheap-wedding-ideas-simple-floral-wedding.jpg",
                        Price = 49.99m,
                        CategoryId = 1
                    },
                    new Product
                    {
                        Id = 4,
                        Name = "Valentine Combo Arrange",
                        Description = "Show your love ones they matter with this beautiful flower arrangement combo. 3 pieces set",
                        ImageUrl = "https://i.etsystatic.com/32684434/r/il/c03705/3538021884/il_fullxfull.3538021884_35mr.jpg",
                        Price = 99.99m,
                        CategoryId = 2
                    }
                );

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }  
    }
}
