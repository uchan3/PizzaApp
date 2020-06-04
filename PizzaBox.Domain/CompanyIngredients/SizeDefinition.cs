using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PizzaBox.Domain.Ingredients
{
  public class SizeDefinition : AComponent
  {
    [Key]
    public int SizeDefID {get; set;}
    //Properties. 
    public SizeDefinition(string name) : base (name) {}
   
    public override string ToString()
    {
      return (this.Name + " Size");
    }

    public static implicit operator Size(SizeDefinition sizeDef)
    {
      return new Size(sizeDef.Name); 
    }
  }
}