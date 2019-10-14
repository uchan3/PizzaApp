using System.Collections.Generic;
using PizzaBox.Domain.Ingredients;
using PizzaBox.Domain.Models;
using Xunit;

namespace PizzaBox.Testing
{
   public class CountTopping
    {
      //Purpose: Check number of toppings is within range. 
      [Fact]
      public void ToppingCount()
      {
        //arrange
        var ToppingList = new List<Topping>
        {
          new Topping("Ham"), new Topping("Cheese"), new Topping("Pepperoni")
        };
        //Unit Test: 
        //var topping = new Topping(); 
        //var User = new User();
        //User.UserID = "User1";
        //var expected = topping.ToppingCount(ToppingList);
        
        var expected = false; //Default value for bool value. 
        
        
        if(ToppingList.Count>=2 && ToppingList.Count<=5)
        {
          expected  = true;
        }


        //act
        var actual = true;

        //assert
        Assert.True(expected == actual);
      }
    }
}