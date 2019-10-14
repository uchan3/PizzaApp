using System;
using System.Collections.Generic;

namespace PizzaBox.Domain.Ingredients
{
  public class Topping : AComponent //Crust inherits from Pizza. 
  {
    public Topping(string name) : base(name) {}

    //Placeholder for the topping list.
    static List <Topping> ToppingList = new List<Topping> 
    {
      new Topping("Cheese"), new Topping("Pepperoni"), 
      new Topping("Ham"), new Topping("Mushroom"), 
      new Topping("Green Pepper"), new Topping("Basil"), new Topping("Lettuce")
    };

    public string ToppingCount(List<Topping> ToppingInput)
    {
      int Topping_Minimal = 2;
      int Topping_Maximum = 5;
      if(ToppingInput.Count>=Topping_Minimal & ToppingInput.Count<=Topping_Maximum)
      {
        return "You are within the limit.";
        //return true;
      }
      else
      {
        return "You have reached the maximum number of toppings.";
        //return false;
      }
      
    }
    
    public override string ToString()
    {
      return (this.Name + " Topping");
    }
  }
}