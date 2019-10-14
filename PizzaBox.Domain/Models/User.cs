using System;
using System.Collections.Generic;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Models
{
    public class User : IEquatable<User>
    {
      public string FirstName {get; set;} 
      public string LastName {get; set;} 
      public string UserID {get; set;}  

    public bool Equals(User other) //Test for equality.  
    {
      if(this.UserID == other.UserID)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    //Placeholder for account list. 
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
        Console.WriteLine("Enter the UserID.");
        User NewUser = new User();
        NewUser.UserID = Console.ReadLine();
        AccountList.Add(NewUser);
        return false;
      }
    }
  }
}

