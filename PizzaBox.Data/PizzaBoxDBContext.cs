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
      //Determined by store: 
      public DbSet<SizeDefinition> SizeDefinition {get; set;}
      public DbSet<CrustDefinition> CrustDefinition {get; set;}
      public DbSet<ToppingDefinition> ToppingDefinition {get; set;}
      public DbSet<StorePizzaDefinition> PizzaDefinition {get; set;}
      public DbSet<Location> LocationList {get; set;}
      
      //Customer:
      public DbSet<User> UserList {get; set;}

      //Keeping track of pizzas and orders. 
      public DbSet<PizzaEntity> PizzaList {get; set;}
      public DbSet<Size> SizeList {get; set;}
      public DbSet<Crust> CrustList {get; set;}
      public DbSet<Topping> ToppingList {get; set;}
      public DbSet<OrderEntity> OrderList {get; set;}
      
      protected override void OnConfiguring(DbContextOptionsBuilder builder)
      {
        //Steps of retrieving DB Connection String from external file
        //var DBString = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: false);
        //var configuration = DBString.Build(); 
        //string str = configuration.GetConnectionString("LocalHost");
        
        builder.UseSqlServer("server=localhost;initial catalog=PizzaBoxDB;user id=sa;password=Password12345;");
      }
      protected override void OnModelCreating(ModelBuilder builder)
      {
        builder.Entity<User>().HasKey( u => u.UserID); 
        builder.Entity<Location>().HasKey( l => l.LocationID); 
        builder.Entity<SizeDefinition>().HasKey( sd => sd.SizeDefID); 
        builder.Entity<CrustDefinition>().HasKey( cd => cd.CrustDefID); 
        builder.Entity<ToppingDefinition>().HasKey( td => td.ToppingDefID); 
        builder.Entity<StorePizzaDefinition>().HasKey( sp => sp.StorePizzaDefID); 

        builder.Entity<OrderEntity>().HasKey( o => o.OrderID); 
        builder.Entity<PizzaEntity>().HasKey( p => p.PizzaID); 
        builder.Entity<Size>().HasKey( s => s.SizeID); 
        builder.Entity<Crust>().HasKey( c => c.CrustID); 
        builder.Entity<Topping>().HasKey( t => t.ToppingID); 
      }
    }
}
