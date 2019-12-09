using System.Collections.Generic;
using PizzaBox.Domain.Ingredients;
//using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Recipes
{
  public class NewYork : APizzaMaker
  {

    public override List<AComponent> Make(Size SizeMake, List<Topping> ToppingMake)
    {
      Crust CrustDefined = new Crust("New York");
      Components.Add(CrustDefined);
      Components.Add(SizeMake);
      Components.AddRange(ToppingMake);
      return this.Components;
    }

    public override string ToString()
    {
      return "New York Pizza";
    }

    public NewYork()
    {
      Price = 5.00M; //TODO: Consider whether this is a good place to put in the price. 
    }
  }
}