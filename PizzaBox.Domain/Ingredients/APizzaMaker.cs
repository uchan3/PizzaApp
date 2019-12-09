using System.Collections.Generic;
using PizzaBox.Domain.Ingredients;

namespace PizzaBox.Domain.Ingredients
{
  public abstract class APizzaMaker
  {
    private List<AComponent> _components = new List<AComponent>(); 

    public decimal Price {get; set;} 
    public List<AComponent> Components
    {
       get{return _components;}
    }

    public abstract List<AComponent> Make(Size SizeInput, List<Topping> ToppingChoice); 

  }
}