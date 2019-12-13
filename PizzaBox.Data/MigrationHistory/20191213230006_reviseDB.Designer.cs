﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PizzaBox.Data;

namespace PizzaBox.Data.MigrationHistory
{
    [DbContext(typeof(PizzaBoxDBContext))]
    [Migration("20191213230006_reviseDB")]
    partial class reviseDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("Name");

                    b.Property<int?>("OrderEntityOrderID");

                    b.Property<int?>("PizzaCrustCrustID");

                    b.Property<int?>("PizzaSizeSizeID");

                    b.Property<decimal>("Price");

                    b.Property<int>("Quantity");

                    b.HasKey("PizzaID");

                    b.HasIndex("OrderEntityOrderID");

                    b.HasIndex("PizzaCrustCrustID");

                    b.HasIndex("PizzaSizeSizeID");

                    b.ToTable("PizzaList");
                });

            modelBuilder.Entity("PizzaBox.Data.OrderEntity", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("LocationIdentifierLocationID");

                    b.Property<DateTime>("OrderDate");

                    b.Property<string>("UserInfoUserID");

                    b.HasKey("OrderID");

                    b.HasIndex("LocationIdentifierLocationID");

                    b.HasIndex("UserInfoUserID");

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

                    b.Property<int?>("PizzaCrustCrustID");

                    b.Property<decimal>("Price");

                    b.HasKey("StorePizzaDefID");

                    b.HasIndex("PizzaCrustCrustID");

                    b.ToTable("PizzaDefinition");
                });

            modelBuilder.Entity("PizzaBox.Domain.Ingredients.Topping", b =>
                {
                    b.Property<int>("ToppingID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<int?>("PizzaEntityPizzaID");

                    b.HasKey("ToppingID");

                    b.HasIndex("PizzaEntityPizzaID");

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
                    b.Property<string>("UserID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("UserID");

                    b.ToTable("UserList");
                });

            modelBuilder.Entity("Pizza.Data.PizzaEntity", b =>
                {
                    b.HasOne("PizzaBox.Data.OrderEntity")
                        .WithMany("PizzaList")
                        .HasForeignKey("OrderEntityOrderID");

                    b.HasOne("PizzaBox.Domain.Ingredients.Crust", "PizzaCrust")
                        .WithMany()
                        .HasForeignKey("PizzaCrustCrustID");

                    b.HasOne("PizzaBox.Domain.Ingredients.Size", "PizzaSize")
                        .WithMany()
                        .HasForeignKey("PizzaSizeSizeID");
                });

            modelBuilder.Entity("PizzaBox.Data.OrderEntity", b =>
                {
                    b.HasOne("PizzaBox.Domain.Models.Location", "LocationIdentifier")
                        .WithMany()
                        .HasForeignKey("LocationIdentifierLocationID");

                    b.HasOne("PizzaBox.Domain.Models.User", "UserInfo")
                        .WithMany()
                        .HasForeignKey("UserInfoUserID");
                });

            modelBuilder.Entity("PizzaBox.Domain.Ingredients.StorePizzaDefinition", b =>
                {
                    b.HasOne("PizzaBox.Domain.Ingredients.Crust", "PizzaCrust")
                        .WithMany()
                        .HasForeignKey("PizzaCrustCrustID");
                });

            modelBuilder.Entity("PizzaBox.Domain.Ingredients.Topping", b =>
                {
                    b.HasOne("Pizza.Data.PizzaEntity")
                        .WithMany("PizzaTopping")
                        .HasForeignKey("PizzaEntityPizzaID");
                });
#pragma warning restore 612, 618
        }
    }
}
