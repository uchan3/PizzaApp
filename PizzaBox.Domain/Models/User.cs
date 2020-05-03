using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Models
{
    public class User : IEquatable<User>
    {
      [Key]
      public int UserID {get; set;}  
      public string FirstName {get; set;} 
      public string LastName {get; set;}
      
      //For now, we choose to compare first and last name. 
      public bool Equals(User other)
      {
        if (other == null) 
        {
          return false; //Edge case: If we do not have other things to compare, should return false. 
        }
        if (this.FirstName == other.FirstName && this.LastName == other.LastName)
        {
          return true;
        }
        else
        {
          return false;
        }
      }
  }
}


