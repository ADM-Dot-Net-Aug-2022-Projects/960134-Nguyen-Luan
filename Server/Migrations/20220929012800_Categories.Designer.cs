﻿// <auto-generated />
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
    [Migration("20220929012800_Categories")]
    partial class Categories
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Hoalu.Shared.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Wedding",
                            Url = "wedding"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Holiday",
                            Url = "holiday"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Gifts",
                            Url = "gifts"
                        });
                });

            modelBuilder.Entity("Hoalu.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 2,
                            Description = "Dozen of Red Roses",
                            ImageUrl = "https://res.cloudinary.com/bloomnation/image/upload/c_pad,d_vendor:global:catalog:product:image.png,f_auto,fl_preserve_transparency,q_auto/v1643762539/vendor/7294/catalog/product/4/c/4c829ffbc556ca0e1fee0faaebe6d8d6_31.jpg",
                            Name = "Red Roses",
                            Price = 12.99m
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 3,
                            Description = "One Orchid plant with Vase",
                            ImageUrl = "https://www.almanac.com/sites/default/files/styles/large/public/image_nodes/orchid-pot-shutterstock_491195248.jpg?itok=k9XxFA4z",
                            Name = "Orchids",
                            Price = 49.99m
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "Amaze your guests with beautiful centerpieces on your table",
                            ImageUrl = "https://i.pinimg.com/564x/3d/a1/e0/3da1e049cc8b83efe88da727d547d00d--easy-cheap-wedding-ideas-simple-floral-wedding.jpg",
                            Name = "Wedding Centerpiece",
                            Price = 49.99m
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            Description = "Show your love ones they matter with this beautiful flower arrangement combo. 3 pieces set",
                            ImageUrl = "https://www.instagram.com/p/ChkilUGJxNn/",
                            Name = "Valentine Combo Arrange",
                            Price = 99.99m
                        });
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
#pragma warning restore 612, 618
        }
    }
}
