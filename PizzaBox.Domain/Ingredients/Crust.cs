using System;

namespace PizzaBox.Domain.Ingredients
{
  public class Crust : AComponent //Crust inherits from Pizza. 
  {
    //Properties. 
    public Crust(string name) : base (name) {}

    //Methods. 

    public override string ToString()
    {
      return (this.Name + " Crust");
    }
    
  }
}