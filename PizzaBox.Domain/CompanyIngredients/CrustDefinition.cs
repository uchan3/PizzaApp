using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PizzaBox.Domain.Ingredients
{
  public class CrustDefinition : AComponent
  {
    [Key]
    public int CrustDefID {get; set;}
    //Properties. 
    public CrustDefinition(string name) : base (name) {}
   
    public override string ToString()
    {
      return (this.Name + " Crust");
    }
  }
}