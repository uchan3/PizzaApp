using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzaBox.Data;
using PizzaBox.Domain.Ingredients;
using PizzaBox.Domain.Models;
using PizzaBox.MVCClient.Models;

namespace PizzaBox.MVCClient.Controllers
{
  public class OrderController : Controller
  {
    PizzaBoxDBContext _db = new PizzaBoxDBContext();
    
    [HttpGet]
    public IActionResult PlaceOrder() 
    {
      OrderViewModel orderForm = new OrderViewModel(); 
      //Test data before utilizing database
      orderForm.LocationList.Add( 
        new Location {LocationID=1, Street = "1234 North St", City = "Dallas", State="TX"}
      );
      orderForm.LocationList.Add(
        new Location {LocationID=2, Street = "5678 South Drive", City = "Denver", State="CO"}
      );

      // orderForm.PizzaTypeList = _db.PizzaDefinition.ToList(); 
      // orderForm.CrustList = _db.CrustDefinition.ToList(); 
      // orderForm.SizeList = _db.SizeDefinition.ToList(); 
      orderForm.ToppingList.AddRange(
        new List<ToppingDefinition>
        {
          new ToppingDefinition("Ham") { ToppingDefID = 1, Name = "Ham"}, 
          new ToppingDefinition("Pepperoni") {ToppingDefID = 2, Name = "Pepperoni"}, 
          new ToppingDefinition("Sausage") {ToppingDefID = 3, Name = "Sausage"}
        }    
      );

      return View(orderForm); 
    }

    [HttpPost]
    public IActionResult PlaceOrder(OrderViewModel values)
    {
      // TODO: Figure out how to post complex values

      // OrderEntity submittedOrder = new OrderEntity()
      // {
      //   UserInfo = _db.UserList.Where( u => u.UserID ==1).FirstOrDefault(),
      //   LocationIdentifier = submitOrder.LocationList.FirstOrDefault(),
      //   OrderDate = DateTime.Now
      // };
      
      // _db.Add(submittedOrder); 
      // _db.SaveChangesAsync(); 
      return RedirectToAction("Index", "Home"); 
    }
    
    [HttpGet]
    //Purpose: View the last order. 
    public IActionResult ViewOrder()
    {
      OrderEntity LastOrder = _db.OrderList.ToList().LastOrDefault();

      //Explicit loading
      _db.Entry(LastOrder).Reference(o => o.UserInfo).Load();
      _db.Entry(LastOrder).Reference(o => o.LocationIdentifier).Load();
      _db.Entry(LastOrder).Collection(o => o.PizzaList).Load();

      //Load the related information in pizza list related to the order. 
      foreach (var pizza in LastOrder.PizzaList)
      {
        //_db.Entry(pizza).Reference( p => p.Name); 
        _db.Entry(pizza).Reference(p => p.PizzaSize).Load();
        _db.Entry(pizza).Reference(p => p.PizzaCrust).Load();
        //_db.Entry(pizza).Collection( p => p.PizzaTopping).Load(); 
      }
      return View(LastOrder);
    }
  }
}