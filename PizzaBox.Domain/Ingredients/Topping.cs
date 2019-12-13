using System;
using System.ComponentModel.DataAnnotations;

namespace PizzaBox.Domain.Ingredients
{
  
  public class Topping : AComponent //Crust inherits from Pizza. 
  {
    [Key]
    public int ToppingID {get; set;}
    public Topping(string name) : base(name) {}
    
    public override string ToString()
    {
      return (this.Name + " Topping");
    }
  }
}