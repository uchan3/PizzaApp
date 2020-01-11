using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaBox.Domain.Ingredients
{
  
  public class Topping : AComponent //Topping inherits from Pizza. 
  {
    [Key]
    public int ToppingID {get; set;}

    //For DB mapping purposes
    [ForeignKey("PizzaEntity")]
    public int PizzaID {get; set;}
    public Topping(string name) : base(name) {}
    
    public override string ToString()
    {
      return (this.Name + " Topping");
    }
  }
}