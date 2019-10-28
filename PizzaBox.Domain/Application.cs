using System;
using System.Collections.Generic;
using PizzaBox.Domain.Ingredients;
using PizzaBox.Domain.Models;
using PizzaBox.Domain.Services;
using PizzaBox.Domain.Recipes;
using System.Linq;
using System.Reflection;

namespace PizzaBox.Domain.Application
{
  public class Application: IPizzaMaker
  {
    public Order1 CreateOrder()
    {
      Console.WriteLine("Welcome. Let's create an order. Type <Add> if you want to add more pizzas.\n" + 
      "Type <Finish> when you are doing with your order.");
      Order1 UserOrder = new Order1();
      
      string OrderInput = Console.ReadLine();
      while(OrderInput=="Add") //Keep adding pizzas until user is done with the order.
      {
        Console.WriteLine("First select the pizza.\n" + 
        "1. Chicago Pizza\n" + 
        "2. New York Pizza"); //TODO: Add Pizzas to order list.

        string PizzaInput = Console.ReadLine(); //Get input of desired pizza. 
        
        Type PizzaType = ReturnType(PizzaInput);
        object PizzaInstance = Activator.CreateInstance(PizzaType); 

        //Customize the size and toppings. 
        Size SizeInput = SelectSize();
        List<Topping> ToppingInput = SelectTopping();

        //Make the pizza! 
        MethodInfo CreatePizza = PizzaType.GetMethod("Make");
        var PizzaReflect = CreatePizza.Invoke(PizzaInstance, new object[] {SizeInput, ToppingInput});

        //Add the pizza to dictionary. 
        UserOrder.PizzaTable.Add(PizzaType.Name, PizzaReflect as List<AComponent>);

        Console.WriteLine("Would you like to add another pizza?\n" + 
        "Enter <Add> to add another pizza. Else, press <Finish> to complete the order.");
        string UserResponse = Console.ReadLine();
        if(UserResponse=="Finish")
        {
          break;
        }
      }
      return UserOrder;        
    }
    
    public void ViewOrder(Order1 FinalizedOrder)
    {
      foreach (var PizzaKey in FinalizedOrder.PizzaTable.Keys)
      {
        Console.WriteLine($"You orderered a {PizzaKey} with the following components:\n");
        foreach(var PizzaComponent in FinalizedOrder.PizzaTable[PizzaKey])
        {
          Console.WriteLine(PizzaComponent.ToString());
        }
      }
    }
    //Temporary Fix. 
    public Type ReturnType(string PizzaInput)
    {
      //Dictionary Mapper. 
      Dictionary<string, Type> PizzaMapper= new Dictionary<string, Type>
      {
        {"Chicago Pizza", typeof(Chicago)}, 
        {"New York Pizza", typeof(NewYork)}
      };
      var PizzaType = PizzaMapper.Where( x => x.Key == PizzaInput).FirstOrDefault().Value;
      return PizzaType;
    }

    public Size SelectSize()
    {
      Console.WriteLine("Please select the following size.\n" + 
      "1. Small \t 2. Medium \t 3. Large");
      string SizeInput = Console.ReadLine(); //TODO: Add validation for size.
      Size TempSize = new Size(SizeInput);
      return TempSize;
    }

    public List<Topping> SelectTopping()
    {
        
        List<Topping> TempTopping  = new List<Topping>();
        while (TempTopping.Count <=5)
        {
          Console.WriteLine("Please select two to five toppings.\n" + 
          "1. Sausage \t 2. Pepperoni \t 3. Ham \t 4. Mushroom \t 5. Green Bell Pepper"); //TODO: Add validation for topping.
          string ToppingInput = Console.ReadLine(); //First, read the value. 
          TempTopping.Add(new Topping(ToppingInput)); //Add to list of toppings.
          Console.WriteLine("Would you like to add another topping? \n" + 
          "Type Y for Yes or N for No \n"); //Decision.
          string Response = Console.ReadLine();
          if(Response=="Y")
          {
            continue; //Continue to next iteration.
          }
          else if(Response=="N")
          {
            break;
          }
        }
      return TempTopping;
    }
   
  }
}