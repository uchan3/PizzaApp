using System;
using System.Collections.Generic;

namespace PizzaBox.Domain.Ingredients
{
  public class Topping : AComponent //Crust inherits from Pizza. 
  {
    public Topping(string name) : base(name) {}
    
    public override string ToString()
    {
      return (this.Name + " Topping");
    }
  }
}