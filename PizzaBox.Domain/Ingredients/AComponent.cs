using System;

namespace PizzaBox.Domain.Ingredients
{
  public abstract class AComponent
  {
    public string Name { get; set; }
    public decimal Price { get; set; }

    public AComponent(string name)
    {
      Name = name;
    }

    public override string ToString()
    {
        return ("Component " + Name);
    }

  }
}
