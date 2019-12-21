using System;

namespace PizzaBox.Domain.Ingredients
{
  //This will be used for interacting with database. 
  //This is a pre-made pizza. User needs to simply select size and toppings. 
  public abstract class APizza
  {
    //Must have features: 
    public string Name { get; set; }
    //public Crust PizzaCrust {get; set;}
    public decimal Price { get; set; }

  }
}