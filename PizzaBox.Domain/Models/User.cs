using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Models
{
    public class User 
    {
      [Key]
      public string UserID {get; set;}  
      public string FirstName {get; set;} 
      public string LastName {get; set;} 
      
    }
}

