using System.Collections.Generic;
using PizzaBox.Domain.Ingredients;

namespace PizzaBox.Domain.Ingredients
{
  public abstract class APizzaMaker
  {
    private List<AComponent> _components = new List<AComponent>(); 

    public List<AComponent> Components
    {
      //_components = new List<AComponent>();
       get
       {
         return _components; //Get the values from the defined component list.
       }
    }

    //public List<
    //public abstract List<AComponent> Make(Size SizeInput, Crust CrustInput); 

    public abstract List<AComponent> Make(Size SizeInput, List<Topping> ToppingChoice); 

/*       public APizzaMaker()
     {
       return this.Make(SizeInput, ToppingChoice);
     }  */
  }
}