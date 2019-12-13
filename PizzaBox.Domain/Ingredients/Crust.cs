using System;
using System.ComponentModel.DataAnnotations;

namespace PizzaBox.Domain.Ingredients
{
  public class Crust : AComponent //Crust inherits from Pizza. 
  {
    [Key] //TODO: Check if this is okay...not sure if it will work?
    public int CrustID {get; set;}
    
    //Properties. 
    public Crust(string name) : base (name) {}

    //Methods. 

    public override string ToString()
    {
      return (this.Name + " Crust");
    }
    
  }
}