using System;
using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
  public class Account
  {
    public string UserID { get; set;} //For simplification, use UserID to check account exists. 
    //protected string Password {get; set;}
    static List<User> AccountList = new List<User>() 
      {
        new User {UserID = "User1"},
        new User {UserID = "User2"},
        new User {UserID = "User3"}
      };
     public bool CheckAccountExist(User UserID)
    {
      if (AccountList.Contains(UserID))
      {
        Console.WriteLine("Welcome. Please select from the following options:\n 1. Select Location\n 2. Create Order");
        return true;
      }
      else
      {
        Console.WriteLine("Apologies. The account does not exist.");
        return false;
      }
    }
  }
}