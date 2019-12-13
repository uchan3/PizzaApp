using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json; 
using Pizza.Data;
using PizzaBox.Domain.Ingredients;
using PizzaBox.Domain.Models;

namespace PizzaBox.Data
{
    public class PizzaBoxDBContext: DbContext
    {
      //Know that we need Size, Crust, Toppings. 
      public DbSet<Size> SizeDefinition {get; set;}
      public DbSet<Crust> CrustDefinition {get; set;}
      public DbSet<Topping> ToppingDefinition {get; set;}

      //Other factors:
      public DbSet<User> UserList {get; set;}
      public DbSet<Location> LocationList {get; set;}

      public DbSet<PizzaEntity> PizzaList {get; set;}
      //public DbSet<Size> SizeEntity {get; set;}

      public DbSet<OrderEntity> OrderList {get; set;}
      
      protected override void OnConfiguring(DbContextOptionsBuilder builder)
      {
        //Steps of retrieving DB Connection String from external file
        var DBString = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: false);
        var configuration = DBString.Build(); 
        string str = configuration.GetConnectionString("LocalHost");
        
        builder.UseSqlServer(str);
      }
      protected override void OnModelCreating(ModelBuilder builder)
      {
        builder.Entity<User>().HasKey( u => u.UserID); 
        builder.Entity<Location>().HasKey( l => l.LocationID); 
        builder.Entity<PizzaEntity>().HasKey( p => p.PizzaID); 
        builder.Entity<OrderEntity>().HasKey( o => o.OrderID); 

        builder.Entity<Size>().HasKey( s => s.SizeID); 
        builder.Entity<Crust>().HasKey( c => c.CrustID); 
        builder.Entity<Topping>().HasKey( t => t.ToppingID); 
      }
    }
}
