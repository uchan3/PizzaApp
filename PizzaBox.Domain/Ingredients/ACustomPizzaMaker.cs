using System.Collections.Generic;
using PizzaBox.Domain.Ingredients;

namespace PizzaBox.Domain.Ingredients
{
  public abstract class ACustomPizzaMaker
  {
    private List<AComponent> _components = new List<AComponent>(); 

    public List<AComponent> Components
    {
      get
      {
        return _components; //Get the values from the defined component list.
      }
    }

    //public abstract List<AComponent> Make(Size SizeInput, Crust CrustInput); 

    public abstract List<AComponent> Make(Size SizeInput, Crust CrustInput, List<Topping> ToppingChoice); 

   /*  public APizzaMaker()
    {
      return this;
    } */
  }
}