using System;
using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
  public class Address
  {
    public string Street { get; set; }
    public string City { get; set; }
    public string StateProvince { get; set; }

     public override string ToString()
     {
       return ("The location is " + Street + ""+ City + "" + StateProvince + ".");
     }
  } 
}