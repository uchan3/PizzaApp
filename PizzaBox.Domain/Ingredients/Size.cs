using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PizzaBox.Domain.Ingredients
{
  public class Size : AComponent
  {
    [Key]
    public int SizeID {get; set;}
    //Properties. 
    public Size(string name) : base (name) {}
   
    public override string ToString()
    {
      return (this.Name + " Size");
    }
  }
}