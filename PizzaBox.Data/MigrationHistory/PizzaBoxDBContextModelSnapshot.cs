﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PizzaBox.Data;

namespace PizzaBox.Data.MigrationHistory
{
    [DbContext(typeof(PizzaBoxDBContext))]
    partial class PizzaBoxDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Pizza.Data.PizzaEntity", b =>
                {
                    b.Property<int>("PizzaID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CrustID");

                    b.Property<string>("Name");

                    b.Property<int>("OrderID");

                    b.Property<decimal>("Price");

                    b.Property<int>("Quantity");

                    b.Property<int>("SizeID");

                    b.HasKey("PizzaID");

                    b.HasIndex("CrustID");

                    b.HasIndex("OrderID");

                    b.HasIndex("SizeID");

                    b.ToTable("PizzaList");
                });

            modelBuilder.Entity("PizzaBox.Data.OrderEntity", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LocationID");

                    b.Property<DateTime>("OrderDate");

                    b.Property<int>("UserID");

                    b.HasKey("OrderID");

                    b.HasIndex("LocationID");

                    b.HasIndex("UserID");

                    b.ToTable("OrderList");
                });

            modelBuilder.Entity("PizzaBox.Domain.Ingredients.Crust", b =>
                {
                    b.Property<int>("CrustID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("CrustID");

                    b.ToTable("CrustList");
                });

            modelBuilder.Entity("PizzaBox.Domain.Ingredients.CrustDefinition", b =>
                {
                    b.Property<int>("CrustDefID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("CrustDefID");

                    b.ToTable("CrustDefinition");
                });

            modelBuilder.Entity("PizzaBox.Domain.Ingredients.Size", b =>
                {
                    b.Property<int>("SizeID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("SizeID");

                    b.ToTable("SizeList");
                });

            modelBuilder.Entity("PizzaBox.Domain.Ingredients.SizeDefinition", b =>
                {
                    b.Property<int>("SizeDefID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("SizeDefID");

                    b.ToTable("SizeDefinition");
                });

            modelBuilder.Entity("PizzaBox.Domain.Ingredients.StorePizzaDefinition", b =>
                {
                    b.Property<int>("StorePizzaDefID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.HasKey("StorePizzaDefID");

                    b.ToTable("PizzaDefinition");
                });

            modelBuilder.Entity("PizzaBox.Domain.Ingredients.Topping", b =>
                {
                    b.Property<int>("ToppingID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<int>("PizzaID");

                    b.HasKey("ToppingID");

                    b.HasIndex("PizzaID");

                    b.ToTable("ToppingList");
                });

            modelBuilder.Entity("PizzaBox.Domain.Ingredients.ToppingDefinition", b =>
                {
                    b.Property<int>("ToppingDefID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("ToppingDefID");

                    b.ToTable("ToppingDefinition");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.Location", b =>
                {
                    b.Property<int>("LocationID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City");

                    b.Property<string>("State");

                    b.Property<string>("Street");

                    b.HasKey("LocationID");

                    b.ToTable("LocationList");
                });

            modelBuilder.Entity("PizzaBox.Domain.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("UserID");

                    b.ToTable("UserList");
                });

            modelBuilder.Entity("Pizza.Data.PizzaEntity", b =>
                {
                    b.HasOne("PizzaBox.Domain.Ingredients.Crust", "PizzaCrust")
                        .WithMany()
                        .HasForeignKey("CrustID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PizzaBox.Data.OrderEntity")
                        .WithMany("PizzaList")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PizzaBox.Domain.Ingredients.Size", "PizzaSize")
                        .WithMany()
                        .HasForeignKey("SizeID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PizzaBox.Data.OrderEntity", b =>
                {
                    b.HasOne("PizzaBox.Domain.Models.Location", "LocationIdentifier")
                        .WithMany()
                        .HasForeignKey("LocationID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PizzaBox.Domain.Models.User", "UserInfo")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PizzaBox.Domain.Ingredients.Topping", b =>
                {
                    b.HasOne("Pizza.Data.PizzaEntity")
                        .WithMany("PizzaTopping")
                        .HasForeignKey("PizzaID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
