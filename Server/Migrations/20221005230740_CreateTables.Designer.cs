// <auto-generated />
using System;
using Hoalu.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hoalu.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221005230740_CreateTables")]
    partial class CreateTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Hoalu.Shared.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("Zip")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("Hoalu.Shared.CartItem", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("UserId", "ProductId", "ProductTypeId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("Hoalu.Shared.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Visible")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Deleted = false,
                            Name = "Flowers",
                            Url = "flowers",
                            Visible = true
                        },
                        new
                        {
                            Id = 2,
                            Deleted = false,
                            Name = "Plants",
                            Url = "plants",
                            Visible = true
                        });
                });

            modelBuilder.Entity("Hoalu.Shared.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("Hoalu.Shared.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Hoalu.Shared.OrderItem", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderId", "ProductId", "ProductTypeId");

                    b.HasIndex("ProductId");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("Hoalu.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Featured")
                        .HasColumnType("bit");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Visible")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Deleted = false,
                            Description = "Blooming with bright colors to boldly express your every emotion, this exquisite flower bouquet is set to celebrate. Hot pink roses, purple Peruvian lilies, lavender mini carnations, green hypericum berries, lily grass blades and lush greens are brought together to create an incredible flower arrangement. Presented in a clear glass cube vase, this mixed flower bouquet will make that perfect impression on a birthday, anniversary, or as a way to extend your congratulations or thank you wishes.",
                            Featured = true,
                            ImageUrl = "https://cdn.azflorist.com/wp-content/uploads/20220405121236/C15-4949D.jpg",
                            Title = "Red Rose Bouquet",
                            Visible = true
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Deleted = false,
                            Description = "This sweet bouquet is an expression of your love and affection. Fragrant pink Stargazer lilies are accented with pink statice and arranged in a clear glass vase. Send it for birthday, anniversary, get well, or just because you care.",
                            Featured = false,
                            ImageUrl = "https://cdn.azflorist.com/wp-content/uploads/20220405122001/S22-4298S.jpg",
                            Title = "Pink Lily Bouquet",
                            Visible = true
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Deleted = false,
                            Description = "Pink Lilies make the eyes dance across the unique design of this flower bouquet, surrounded by the blushing colors of orange roses, lavender cushion poms, hot pink carnations, and lush greens. Presented in a clear glass vase, this fresh flower arrangement has been created just for you to help you send your sweetest thank you, happy anniversary, or thinking of you wishes.",
                            Featured = false,
                            ImageUrl = "https://cdn.azflorist.com/wp-content/uploads/20220405123118/C5375D.png",
                            Title = "Sunset Bouquet",
                            Visible = true
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Deleted = false,
                            Description = "Our local florists handcraft a stunning display of lilies, roses and other elegant florals to delight them for any and every occasion.",
                            Featured = true,
                            ImageUrl = "https://cdn.azflorist.com/wp-content/uploads/20220524092019/CHAD.jpeg",
                            Title = "The Pure Clouds",
                            Visible = true
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            Deleted = false,
                            Description = "For that superstar in your life, treat them to something so gorgeous, it’s out of this world. Designed by a local florist, the Moonstruck Bouquet comes with a refreshing mix of white florals and arrives in style right to their doorstep.",
                            Featured = true,
                            ImageUrl = "https://cdn.azflorist.com/wp-content/uploads/20220524101105/PGQP.png",
                            Title = "Moonstruck Bouquet",
                            Visible = true
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 1,
                            Deleted = false,
                            Description = "Stunning sunflowers are mixed with glossy magnolia leaves for a dramatic, day-brightening delivery.",
                            Featured = false,
                            ImageUrl = "https://image.floranext.com/instances/theflowercart_org/catalog/product/y/o/youregoldenbouquetbyteleflora_1.jpg?w=308&h=308&gen=1",
                            Title = "Sunflower Bouquet",
                            Visible = true
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 2,
                            Deleted = false,
                            Description = "Beautiful dyed Blue Orchid plant, Perfect for someone who loves blue, new baby boy or a special man in your life!",
                            Featured = false,
                            ImageUrl = "https://fyf.tac-cdn.net/images/products/large/P-149.jpg?auto=webp&quality=60&width=690",
                            Title = "Blue Orchid",
                            Visible = true
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 2,
                            Deleted = false,
                            Description = "Enjoy the southwest with this prickly but beautiful cactus garden.",
                            Featured = false,
                            ImageUrl = "https://www.treehugger.com/thmb/VpYez07ecRrO4et_DV080D30ErA=/735x0/__opt__aboutcom__coeus__resources__content_migration__mnn__images__2017__09__SucculentsRoundGardenTrayInFrontOfBench-b92233aff63940f8a4ea98981ab98d1d.jpg",
                            Title = "Cactus Garden",
                            Visible = true
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 2,
                            Deleted = false,
                            Description = "The striking Phalaenopsis orchid makes a graceful tribute to loved ones who have passed on. Tastefully set by our florists in a classic glass cube planter, its vibrant green leaves and wing-shaped white blooms are a thoughtful gesture of sympathy when delivered to the home of friends and family.",
                            Featured = false,
                            ImageUrl = "https://cdn.shopify.com/s/files/1/0150/6262/products/the-sill_white-orchid_bryant_black_variant.jpg?v=1658772624",
                            Title = "White Orchid",
                            Visible = true
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 2,
                            Deleted = false,
                            Description = "Like a best friend, this unique garden of fresh green succulents is adaptable, low-maintenance, and a great addition to any setting.",
                            Featured = false,
                            ImageUrl = "https://www.bhg.com/thmb/Bsu_svLq5LOM8AvgUgFyDDwb4cg=/1866x1050/smart/filters:no_upscale():focal(1006x509:1008x511)/mini-succulent-container-663ff722-8f8200d7ec4341bea48bc9e4df5d33dc.jpg",
                            Title = "Succelent Garden",
                            Visible = true
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 2,
                            Deleted = false,
                            Description = "The sansevieria or snake plant, features naturalistic river grass and an organic shape. These trendy baskets add style and character to a living room or bedroom. The neutral color and texture fits perfectly in a variety of home settings.\r\nSansevieria is one of the top air purifying plants identified by NASA, removing at least 108 known air pollutants. It is also one of the few plants that releases oxygen during the night.",
                            Featured = false,
                            ImageUrl = "https://images.costco-static.com/ImageDelivery/imageService?profileId=12026540&imageId=1327184-847__1&recipeName=350",
                            Title = "Sansevieria Snake Plant",
                            Visible = true
                        });
                });

            modelBuilder.Entity("Hoalu.Shared.ProductType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Mini"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Regular"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Large"
                        });
                });

            modelBuilder.Entity("Hoalu.Shared.ProductVariant", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("ProductTypeId")
                        .HasColumnType("int");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<decimal>("OriginalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Visible")
                        .HasColumnType("bit");

                    b.HasKey("ProductId", "ProductTypeId");

                    b.HasIndex("ProductTypeId");

                    b.ToTable("ProductVariants");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            ProductTypeId = 1,
                            Deleted = false,
                            OriginalPrice = 0m,
                            Price = 19.99m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 1,
                            ProductTypeId = 2,
                            Deleted = false,
                            OriginalPrice = 0m,
                            Price = 29.99m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 1,
                            ProductTypeId = 3,
                            Deleted = false,
                            OriginalPrice = 0m,
                            Price = 39.99m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 2,
                            ProductTypeId = 1,
                            Deleted = false,
                            OriginalPrice = 0m,
                            Price = 19.99m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 2,
                            ProductTypeId = 2,
                            Deleted = false,
                            OriginalPrice = 0m,
                            Price = 29.99m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 2,
                            ProductTypeId = 3,
                            Deleted = false,
                            OriginalPrice = 0m,
                            Price = 39.99m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 3,
                            ProductTypeId = 2,
                            Deleted = false,
                            OriginalPrice = 0m,
                            Price = 49.99m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 3,
                            ProductTypeId = 3,
                            Deleted = false,
                            OriginalPrice = 0m,
                            Price = 69.99m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 4,
                            ProductTypeId = 2,
                            Deleted = false,
                            OriginalPrice = 0m,
                            Price = 49.99m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 4,
                            ProductTypeId = 3,
                            Deleted = false,
                            OriginalPrice = 0m,
                            Price = 69.99m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 5,
                            ProductTypeId = 1,
                            Deleted = false,
                            OriginalPrice = 0m,
                            Price = 25.99m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 5,
                            ProductTypeId = 2,
                            Deleted = false,
                            OriginalPrice = 0m,
                            Price = 35.99m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 6,
                            ProductTypeId = 1,
                            Deleted = false,
                            OriginalPrice = 0m,
                            Price = 45.99m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 6,
                            ProductTypeId = 2,
                            Deleted = false,
                            OriginalPrice = 0m,
                            Price = 55.99m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 7,
                            ProductTypeId = 2,
                            Deleted = false,
                            OriginalPrice = 0m,
                            Price = 35.99m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 8,
                            ProductTypeId = 1,
                            Deleted = false,
                            OriginalPrice = 0m,
                            Price = 15.99m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 9,
                            ProductTypeId = 2,
                            Deleted = false,
                            OriginalPrice = 0m,
                            Price = 35.99m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 10,
                            ProductTypeId = 1,
                            Deleted = false,
                            OriginalPrice = 0m,
                            Price = 15.99m,
                            Visible = true
                        },
                        new
                        {
                            ProductId = 11,
                            ProductTypeId = 3,
                            Deleted = false,
                            OriginalPrice = 0m,
                            Price = 45.99m,
                            Visible = true
                        });
                });

            modelBuilder.Entity("Hoalu.Shared.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Hoalu.Shared.Address", b =>
                {
                    b.HasOne("Hoalu.Shared.User", null)
                        .WithOne("Address")
                        .HasForeignKey("Hoalu.Shared.Address", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Hoalu.Shared.Image", b =>
                {
                    b.HasOne("Hoalu.Shared.Product", null)
                        .WithMany("Images")
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("Hoalu.Shared.OrderItem", b =>
                {
                    b.HasOne("Hoalu.Shared.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hoalu.Shared.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hoalu.Shared.ProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");

                    b.Navigation("ProductType");
                });

            modelBuilder.Entity("Hoalu.Shared.Product", b =>
                {
                    b.HasOne("Hoalu.Shared.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Hoalu.Shared.ProductVariant", b =>
                {
                    b.HasOne("Hoalu.Shared.Product", "Product")
                        .WithMany("Variants")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hoalu.Shared.ProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("ProductType");
                });

            modelBuilder.Entity("Hoalu.Shared.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("Hoalu.Shared.Product", b =>
                {
                    b.Navigation("Images");

                    b.Navigation("Variants");
                });

            modelBuilder.Entity("Hoalu.Shared.User", b =>
                {
                    b.Navigation("Address")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
