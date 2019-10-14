using System;
using System.Collections.Generic;

namespace PizzaBox.Domain.Ingredients
{
  public class Size : AComponent, IEquatable<Size> //Size inherits from Pizza. 
  {
    //Properties. 
    public Size(string name) : base (name) {}
    static List <Size> SizeList = new List <Size>
    {
      new Size("Small"), 
      new Size("Medium"), 
      new Size("Large")
    };
    //Methods. 

    public string SelectSize(Size SizeInput) //Pizza can only have one size. 
    {
      
      if(SizeList.Contains(SizeInput))
        {
          Console.WriteLine("The size has been added.");
          return SizeInput.ToString();
        }
      else
        {
          Console.WriteLine("The size does not exist. ");
          return "";
        }
    }

    public bool Equals(Size other) //Check for equality. 
    {
      if(this.Name == other.Name)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public override string ToString()
    {
      return (this.Name + " Size");
    }
  }
}