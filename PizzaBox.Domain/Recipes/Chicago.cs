using System.Collections.Generic;
using PizzaBox.Domain.Ingredients;

namespace PizzaBox.Domain.Recipes
{
  public class Chicago : APizzaMaker
  {

    public override List<AComponent> Make(Size SizeMake, List<Topping> ToppingMake) 
    {
        Crust CrustDefined = new Crust("Chicago");
        Components.Add(CrustDefined);
        Components.Add(SizeMake);
        Components.AddRange(ToppingMake);
        return this.Components;
    }

     public override string ToString()
    {
      return "Chicago Pizza";
    }

    public Chicago()
    {
      Price = 6.00M;
    }
  }
}