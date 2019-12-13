using System.Collections.Generic;
using PizzaBox.Domain.Ingredients;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Services
{
    public interface IPizzaMaker
    {
      Order CreateOrder();

      Size SelectSize();
      List<Topping> SelectTopping();

    }
}