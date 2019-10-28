using System;
using System.Collections.Generic;
using PizzaBox.Domain.Ingredients;
using PizzaBox.Domain.Recipes;
using PizzaBox.Domain.Services;

namespace PizzaBox.Domain.Models
{
    public class Order1
    {
      //Properties.
      //public List<APizzaMaker> Pizzas { get; set; }
      public Dictionary<String, List<AComponent>> PizzaTable {get; set;}

      //Constructor
      public Order1() {
        this.PizzaTable = new Dictionary<string, List<AComponent>>(); //Must be initialized. 
      }
    }
}