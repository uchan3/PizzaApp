using System;
using System.Collections.Generic;

namespace PizzaBox.Domain.Models
{
  public class Address: IEquatable<Address>
  {
    public string Street { get; set; }
    public string City { get; set; }
    public string StateProvince { get; set; }
    static List<Address> AddressList = new List<Address>()
      {
        new Address {StateProvince = "Texas", City = "Arlington", Street = "Street1"},
        new Address {StateProvince = "Texas", City = "Arlington", Street = "Street2"},
        new Address {StateProvince = "Texas", City = "Dallas", Street = "Street3"},
        new Address {StateProvince = "Texas", City = "Dallas", Street = "Street4"}
      };

     public override string ToString()
     {
       return ("The location is " + Street + ""+ City + "" + StateProvince + ".");
     }
     public string CheckLocationID(Address Address_Input)
    {
      
      if (AddressList.Contains(Address_Input))
      {
        return Address_Input.ToString();
      }
      else
      {
        return "The address does not exist.";
      }

    }

    public bool Equals(Address other) //Check for equality in List. 
    {
       if(this.Street == other.Street && this.City == other.City 
            && this.StateProvince == other.StateProvince)
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