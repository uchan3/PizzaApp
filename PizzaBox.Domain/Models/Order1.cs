using System;
using System.Collections.Generic;
using PizzaBox.Domain.Ingredients;
using PizzaBox.Domain.Recipes;
using PizzaBox.Domain.Services;

namespace PizzaBox.Domain.Models
{
    public class Order1
    {
      //Fields. 
      public int LimitCount = 100;
      public decimal LimitPrice = 5000.00M;
      //Properties.
      //public List<APizzaMaker> Pizzas { get; set; }
      public Dictionary<String, List<AComponent>> PizzaTable {get; set;}

      public List<int> LimitArray { get; set;} //Using an array to keep track of count. 

      public List<decimal> PriceArray { get; set;} //Using an array to keep track of price. 

      //Constructor
      public Order1() {
        this.PizzaTable = new Dictionary<string, List<AComponent>>(); //Must be initialized. 
        this.LimitArray = new List<int>(); 
        this.PriceArray = new List<decimal>(); 
      }
    }
}