using System.Collections.Generic;
using PizzaBox.Domain.Ingredients;
//using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Recipes
{
  public class NewYork : APizzaMaker
  {
    //public static string Size;
    public static string Size_Final;

    public override List<AComponent> Make(Size SizeMake, List<Topping> ToppingMake) 
    {
        Crust CrustDefined = new Crust("New York");
        Components.Add(CrustDefined);
        Components.Add(SizeMake);
        Components.AddRange(ToppingMake);
        return this.Components;
        //return this.Make(SizeMake, ToppingMake);
    }

    public override string ToString()
    {
      return "New York Pizza";
    }
  }
}