using System;
using System.Collections.Generic;
using PizzaBox.Domain.Ingredients;
using PizzaBox.Domain.Recipes;

namespace PizzaBox.Domain.Models
{
    public class Order1
    {
      public List<APizzaMaker> Pizzas { get; set; }
      public Dictionary<String, List<AComponent>> PizzaTable {get; set;}
    }
}