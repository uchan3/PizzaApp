using System;
using System.Collections.Generic;
using System.Linq;
using Pizza.Data;
using PizzaBox.Data;
using PizzaBox.Domain.Ingredients;
using PizzaBox.Domain.Models;

namespace PizzaBox.Client.Sessions
{
  public class ApplicationDB
  {
    PizzaBoxDBContext _db = new PizzaBoxDBContext();

    //Focus: How to create & persist order information? 
    public void CreateOrder()
    {
      User UserSelect = ValidateUser();
      Location LocationSelect = SelectLocation();
      Console.WriteLine("Welcome. Let's start by creating an order.\n" +
      "Type Add to add more pizzas. Type Finish to complete order.");
      OrderEntity order = new OrderEntity();

      string input = Console.ReadLine();
      while (input == "Add")
      {
        PizzaEntity tempPizza = new PizzaEntity();
        //Step 1: What kind of pizza to order???
        StorePizzaDefinition tempPizzaName = SelectPizzaType();

        //Step 2: Make the pizza. 
        Crust tempCrust = SelectCrust();
        Size tempSize = SelectSize();
        List<Topping> tempTopping = CreateToppingList();

        //Step 3: Choose the quantity. 
        Console.WriteLine("How many pizzas do you want?");
        string QuantityChoice = Console.ReadLine();

        //Step 4: Map the information into the pizza entity. 
        tempPizza.Name = tempPizzaName.Name;
        tempPizza.Price = tempPizzaName.Price;
        tempPizza.Quantity = Int32.Parse(QuantityChoice);
        tempPizza.PizzaCrust = tempCrust;
        tempPizza.PizzaSize = tempSize;
        tempPizza.PizzaTopping = tempTopping;

        //Step 5: Add the pizza entity to order. 
        order.PizzaList.Add(tempPizza);

        Console.WriteLine("Would you like to make another pizza?\n" + 
        "As a reminder, type Add to add another pizza. Type Finish to complete order."); 
        string UserDecision = Console.ReadLine(); 
        if (UserDecision == "Finish") {
          break; 
        }
      }

      //Final steps: Add user/location info to order and submit order. 
      order.UserInfo = UserSelect;
      order.LocationIdentifier = LocationSelect;
      order.OrderDate = DateTime.Today;

      _db.OrderList.Add(order);
      _db.SaveChanges();
    }

    public void ViewOrder() {
      //Ensure order information is persisting. 
      Console.WriteLine("Retrieve the most recent order submitted.\n"); 

      var countOrder = _db.OrderList.Count(); //Works. Knows there are a total of 4 orders. 
      Console.WriteLine("There are a total of " + countOrder + " orders."); 
      //OrderEntity LastOrder = _db.OrderList.FirstOrDefault( l => l.LocationIdentifier.LocationID == 2); 
      
      //TODO: Ensure the column names match\\
      foreach (var order in _db.OrderList)
      {
          Console.WriteLine("The order date is " + order.OrderDate); 
      }
      //string UserName = LastOrder.UserInfo.FirstName; 
      //Console.WriteLine("The order has been placed by: " + UserName);
      //Console.WriteLine($"The order was submitted to : {ViewOrder.LocationIdentifier.Street}.\n"); 
      //Console.WriteLine($"The order was submitted at : {ViewOrder.OrderDate}.\n"); 

      // foreach (var PizzaChoice in ViewOrder.PizzaList)
      // {
      //     Console.WriteLine($"The pizza selected is {PizzaChoice.Name}" + 
      //     "with the following components: \n");
      //     Console.WriteLine($"Size: {PizzaChoice.PizzaSize.Name}"); 
      //     Console.WriteLine($"Crust: {PizzaChoice.PizzaCrust.Name}"); 
      //     foreach (var ToppingChoice in PizzaChoice.PizzaTopping) 
      //     {
      //       Console.WriteLine($"Topping: {ToppingChoice.Name}"); 
      //     }
      //     Console.WriteLine("--------------------------------"); 
      //     Console.WriteLine($"The cost of the pizza you selected is: {PizzaChoice.Price}"); 
      //     Console.WriteLine($"The quantity of pizzas you selected is: {PizzaChoice.Quantity}"); 
      // }
      
      // var totalQuantity = ViewOrder.PizzaList.Sum( q => q.Quantity); 
      // Console.WriteLine("The total quantity is: " + totalQuantity); 

      // var totalCost = (from pizza in ViewOrder.PizzaList
      //                 select pizza.Quantity*pizza.Price).Sum();
      
      // Console.WriteLine("The total cost for this order is: " + totalCost); 
    }

    public User ValidateUser()
    {
      Console.WriteLine("Welcome. Please type first/last name to get started.");
      string FirstName = Console.ReadLine();
      string LastName = Console.ReadLine();

      User UserSession = _db.UserList.FirstOrDefault(u => u.FirstName == FirstName && u.LastName == LastName);
      return UserSession;
    }

    public Location SelectLocation()
    {
      Console.WriteLine("Please select the location from the following list. Type in LocationID to choose location.");
      foreach (var LocationItem in _db.LocationList)
      {
        Console.WriteLine($"{LocationItem.LocationID}: {LocationItem.Street}: {LocationItem.City}");
      }
      string LocationID = Console.ReadLine();
      Location LocationSelect = _db.LocationList.FirstOrDefault(l => l.LocationID == Int32.Parse(LocationID));
      return LocationSelect;
    }

    public StorePizzaDefinition SelectPizzaType()
    {
      Console.WriteLine("Select the type of pizza you want to make. Type in name of pizza to select pizzatype.");
      foreach (var PizzaDef in _db.PizzaDefinition)
      {
        Console.WriteLine($"{PizzaDef.Name}: {PizzaDef.Price}");
      }
      string PizzaType = Console.ReadLine();
      StorePizzaDefinition SelectPizza = _db.PizzaDefinition.FirstOrDefault(pt => pt.Name == PizzaType);
      return SelectPizza;
    }

    public Size SelectSize()
    {
      Console.WriteLine("Select the size of pizza. Type in the name of the size.");
      foreach (var SizeDef in _db.SizeDefinition)
      {
        Console.WriteLine($"{SizeDef.Name}");
      }
      string SizeChoice = Console.ReadLine();
      SizeDefinition ChooseSize = _db.SizeDefinition.FirstOrDefault(s => s.Name == SizeChoice);
      return new Size(SizeChoice)
      {
        //SizeID = ChooseSize.SizeDefID, 
        Name = ChooseSize.Name
      };
    }

    public Crust SelectCrust()
    {
      Console.WriteLine("Select the crust of pizza. Type in the name of the crust.");
      foreach (var CrustDef in _db.CrustDefinition)
      {
        Console.WriteLine($"{CrustDef.Name}");
      }
      string CrustChoice = Console.ReadLine();
      CrustDefinition ChooseCrust = _db.CrustDefinition.FirstOrDefault(c => c.Name == CrustChoice);
      return new Crust(CrustChoice)
      {
        //CrustID = ChooseCrust.CrustDefID, 
        Name = ChooseCrust.Name
      };
    }

    public Topping SelectTopping()
    {
      Console.WriteLine("Select the topping you want");
      foreach (var ToppingDef in _db.ToppingDefinition)
      {
        Console.WriteLine($"{ToppingDef.Name}");
      }
      string ToppingChoice = Console.ReadLine();
      ToppingDefinition ChooseTopping = _db.ToppingDefinition.FirstOrDefault(t => t.Name == ToppingChoice);
      return new Topping(ToppingChoice)
      {
        Name = ChooseTopping.Name
      };
    }

    public List<Topping> CreateToppingList()
    {
      List<Topping> TempTopping = new List<Topping>();
      while (TempTopping.Count <= 5)
      {
        Topping ChooseTopping = SelectTopping();
        //string ToppingInput = Console.ReadLine(); //First, read the value. 
        //TempTopping.Add(new Topping(ToppingInput)); //Add to list of toppings.
        TempTopping.Add(ChooseTopping);
        Console.WriteLine("Would you like to add another topping? \n" +
        "Type Y for Yes or N for No \n"); //Decision.
        string Response = Console.ReadLine();
        if (Response == "Y")
        {
          //Validate number of toppings. 
          int ToppingCount = TempTopping.Count;
          if (ToppingCount == 1)
          {
            Console.WriteLine("You must select at least one more topping.");
            continue;
          }
          else if (ToppingCount == 5)
          {
            Console.WriteLine("You have reached the maximum number of toppings.");
            break;
          }
          //continue; //Continue to next iteration.
        }
        else
        {
          break;
        }
      }
      return TempTopping;

    }

    //Test connections are working. -->Yes. Working. 
    //Size Definition List
    public void ViewIngredients()
    {
      foreach (var item in _db.SizeDefinition.ToList())
      {
        Console.WriteLine($"The size is: {item}.");
      }
      foreach (var item in _db.CrustDefinition.ToList())
      {
        Console.WriteLine($"The crust is: {item}");
      }
    }

  }
}