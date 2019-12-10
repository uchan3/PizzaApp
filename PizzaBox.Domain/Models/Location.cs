using System.Collections.Generic;
using PizzaBox.Domain.Ingredients;

namespace PizzaBox.Domain.Models
{
  public class Location
  {
    public Address Address {get; set;}
    public Dictionary <string, int> Inventory {get; set;} 
    public List<Order1> OrderHistory {get; set;}
    
    private List<User> _userList = new List<User>(); //Location views its own list of users. 

    public List<User> UserList
    {
      get
      {
        return _userList; //View the list of users. 
      }
    }
    
    private List<AComponent> _components = new List<AComponent>();

    public List<AComponent> Components
    {
      get
      {
        return _components;
      }
    }
   /*   List<AComponent> MakePizza(Crust c, Size s, List<Topping> t)
    {
      return 
      (
        Components.Add(c);
        Components.Add(s);
        Components.Add(t);
      )
    } */
  }
}