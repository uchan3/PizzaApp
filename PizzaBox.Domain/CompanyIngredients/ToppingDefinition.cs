using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PizzaBox.Domain.Ingredients
{
  public class ToppingDefinition : AComponent
  {
    [Key]
    public int ToppingDefID {get; set;}
    //Properties. 
    public ToppingDefinition(string name) : base (name) {}
   
    public override string ToString()
    {
      return (this.Name + " Topping");
    }
  }
}