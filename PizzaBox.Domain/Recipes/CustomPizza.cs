using System.Collections.Generic;
using PizzaBox.Domain.Ingredients;

namespace PizzaBox.Domain.Recipes
{
  public class CustomPizza : ACustomPizzaMaker
  {
    //public static string Size;
    public static string Size_Final;

    public override List<AComponent> Make(Size SizeMake, Crust CrustMake, List<Topping> ToppingMake) 
    {
        Components.Add(CrustMake);
        Components.Add(SizeMake);
        Components.AddRange(ToppingMake);
        return this.Components;
    }
  }
}