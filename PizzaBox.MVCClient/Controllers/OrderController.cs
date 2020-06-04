using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzaBox.Data;
using PizzaBox.Domain.Ingredients;
using PizzaBox.Domain.Models;
using PizzaBox.MVCClient.Models;
using PizzaBox.MVCClient.Custom;
using System.Threading.Tasks;

namespace PizzaBox.MVCClient.Controllers
{
  public class OrderController : Controller
  {
    //TODO: Deal with _db later. 
    //PizzaBoxDBContext _db = new PizzaBoxDBContext(); 
    
    private List<Location> LocationList = new List<Location>
    {
      new Location {LocationID=1, Street = "1234 North St", City = "Dallas", State="TX"}, 
      new Location {LocationID=2, Street = "5678 South Drive", City = "Denver", State="CO"}
    };

    private List<StorePizzaDefinition> PizzaTypeList = new List<StorePizzaDefinition>
    {
      new StorePizzaDefinition {StorePizzaDefID=1, Name = "Chicago", Price = 5M}, 
      new StorePizzaDefinition {StorePizzaDefID=2, Name = "New York", Price = 6M}
    };

    private List<CrustDefinition> CrustList = new List<CrustDefinition>
    {
      new CrustDefinition("Chicago") {CrustDefID = 1}, 
      new CrustDefinition("New York") {CrustDefID = 2}
    };

    private List<SizeDefinition> SizeList = new List<SizeDefinition>
    {
      new SizeDefinition("Small") {SizeDefID = 1}, 
      new SizeDefinition("Medium") {SizeDefID = 2}, 
      new SizeDefinition("Large") {SizeDefID = 3}
    };
    
    private List<ToppingDefinition> ToppingList = new List<ToppingDefinition>
    {
      new ToppingDefinition("Ham") { ToppingDefID = 1}, 
      new ToppingDefinition("Pepperoni") {ToppingDefID = 2}, 
      new ToppingDefinition("Sausage") {ToppingDefID = 3}, 
      new ToppingDefinition("Cheese") {ToppingDefID = 4},
      new ToppingDefinition("Green Pepper") {ToppingDefID = 5},
      new ToppingDefinition("Special") {ToppingDefID = 6},
    };

    [HttpGet]
    public IActionResult PlaceOrder() 
    {
      OrderViewModel orderForm = mapOrderModel();

      // orderForm.PizzaTypeList = _db.PizzaDefinition.ToList(); 
      // orderForm.CrustList = _db.CrustDefinition.ToList(); 
      // orderForm.SizeList = _db.SizeDefinition.ToList(); 
      
      //TODO: Figure out why error message is not showing. 
      if(TempData["ToppingErrorCount"] != null)
      {
        ViewData["ToppingErrorCount"] = TempData["ToppingErrorCount"].ToString();
        //return View(orderForm);
      }
      if(TempData["Pizza1"] != null)
      {
        TempData.Keep(); //Keep original pizza values for retention. 
      }
      return View(orderForm); 
    }

    [HttpPost]
    public IActionResult PlaceOrder(OrderViewModel orderValues, string submit)
    {
      // To consider: Figure out how to post complex values
      
      //First, validate the topping count.
      int countToppings = orderValues.SelectToppings.Count(); //Debugging
      if (orderValues.SelectToppings.Count() > 5)
      {
        TempData["ToppingErrorCount"] = "Please select 5 toppings"; //Persist information. 
        return RedirectToAction("PlaceOrder");
      }
      //If toppings validation is successful, then map values to Pizza.
      else if (submit.Equals("add"))
      {
        PizzaEntity tempPizza1 = mapPizzaValues(orderValues);  
        TempData.Set("Pizza1", tempPizza1); 
        return RedirectToAction("PlaceOrder");
      }
      else 
      {
        PizzaEntity tempPizza1 = TempData.Get<PizzaEntity>("Pizza1");
        PizzaEntity tempPizza2 = mapPizzaValues(orderValues);    
        //OrderEntity submittedOrder = new OrderEntity(); //Create new order entity. 
      
      // _db.Add(submittedOrder); //Save to database. 
      // _db.SaveChangesAsync();    
        return RedirectToAction("Index", "Home");  
      }     
    }
    
    [HttpGet]
    //Purpose: View the last order. 
    public IActionResult ViewOrder()
    {
      // OrderEntity LastOrder = _db.OrderList.ToList().LastOrDefault();

      // //Explicit loading
      // _db.Entry(LastOrder).Reference(o => o.UserInfo).Load();
      // _db.Entry(LastOrder).Reference(o => o.LocationIdentifier).Load();
      // _db.Entry(LastOrder).Collection(o => o.PizzaList).Load();

      // //Load the related information in pizza list related to the order. 
      // foreach (var pizza in LastOrder.PizzaList)
      // {
      //   //_db.Entry(pizza).Reference( p => p.Name); 
      //   _db.Entry(pizza).Reference(p => p.PizzaSize).Load();
      //   _db.Entry(pizza).Reference(p => p.PizzaCrust).Load();
      //   //_db.Entry(pizza).Collection( p => p.PizzaTopping).Load(); 
      return View(); 
    }
      //return View(LastOrder);
      
      //Temp. way to instantiate new order model...so next HTTP request doesn't return null. 
      public OrderViewModel mapOrderModel()
      {
        return new OrderViewModel
        {
          LocationList = this.LocationList,
          PizzaTypeList = this.PizzaTypeList,
          CrustList = this.CrustList,
          SizeList = this.SizeList,
          ToppingList = this.ToppingList
        };
      }

      private PizzaEntity mapPizzaValues(OrderViewModel orderValues)
      {
        PizzaEntity tempPizza = new PizzaEntity();
        //Map the values. 
        Crust tempCrust = CrustList[orderValues.SelectCrust-1];
        Size tempSize = SizeList[orderValues.SelectSize-1];
        foreach(var topping in orderValues.SelectToppings)
        {
          Topping tempTopping = ToppingList[topping-1];
          tempPizza.PizzaTopping.Add(tempTopping);
        }
        tempPizza.PizzaCrust = tempCrust;
        tempPizza.PizzaSize = tempSize;
        return tempPizza;
      }
    }
}