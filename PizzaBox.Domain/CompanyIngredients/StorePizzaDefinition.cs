using System;
using System.ComponentModel.DataAnnotations;

namespace PizzaBox.Domain.Ingredients
{
  //This will be used for interacting with database. 
  //This is a pre-made pizza. User needs to simply select size and toppings. 
  public class StorePizzaDefinition: APizza
  {
    [Key]
    public int StorePizzaDefID {get; set;}
  }
}