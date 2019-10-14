using System.Collections.Generic;
using PizzaBox.Domain.Ingredients;

namespace PizzaBox.Domain.Recipes
{
  public class Chicago : APizzaMaker
  {
    //public static string Size;
    public static string Size_Final;

    public override List<AComponent> Make(Size SizeMake, List<Topping> ToppingMake) 
    {
        Crust CrustDefined = new Crust("Chicago");
        Components.Add(CrustDefined);
        Components.Add(SizeMake);
        Components.AddRange(ToppingMake);
        return this.Components;
    }
  }
}