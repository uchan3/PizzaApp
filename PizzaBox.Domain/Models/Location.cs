using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PizzaBox.Domain.Ingredients;

namespace PizzaBox.Domain.Models
{
  public class Location
  {
    //Let's start off with Address and add on. 
    [Key]
    public int LocationID {get; set;}
    public string Street {get; set;}
    public string City {get; set;}
    public string State {get; set;}

    //TODO: Address the below stuff in the future: 

    // public Address Address {get; set;}
    // public Dictionary <string, int> Inventory {get; set;} 
    // public List<Order> OrderHistory {get; set;}
    
    // private List<User> _userList = new List<User>(); //Location views its own list of users. 

    // public List<User> UserList
    // {
    //   get
    //   {
    //     return _userList; //View the list of users. 
    //   }
    // }
    
  }
}