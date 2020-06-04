using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PizzaBox.Domain.Ingredients;
using PizzaBox.Domain.Models;

namespace PizzaBox.MVCClient.Models
{
    public class OrderViewModel 
    {
      //Data-lists to load
      public List<Location> LocationList {get; set;}
      public List<StorePizzaDefinition> PizzaTypeList {get; set;}
      public List<CrustDefinition> CrustList {get; set;}
      public List<SizeDefinition> SizeList {get; set;}
      public List<ToppingDefinition> ToppingList {get; set;}
      //Binding properties
      public int SelectLocation {get; set;}
      public int SelectPizzaType {get; set;}
      public int SelectCrust {get; set;} 
      public int SelectSize {get; set;}
      public int[] SelectToppings {get; set;}

      public OrderViewModel()
      {
        //Used to initialize the lists. 
        this.LocationList = new List<Location>(); 
        this.PizzaTypeList = new List<StorePizzaDefinition>();
        this.CrustList = new List<CrustDefinition>();
        this.SizeList = new List<SizeDefinition>();
        this.ToppingList = new List<ToppingDefinition>(); 
      }
    }
}