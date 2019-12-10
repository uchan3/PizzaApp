using System;
using System.Collections.Generic;

namespace PizzaBox.Domain.Ingredients
{
  public class Size : AComponent
  {
    //Properties. 
    public Size(string name) : base (name) {}
   
    public override string ToString()
    {
      return (this.Name + " Size");
    }
  }
}