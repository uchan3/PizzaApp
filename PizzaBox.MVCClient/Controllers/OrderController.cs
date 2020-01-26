using System;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzaBox.Data;
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
      orderForm.LocationList = _db.LocationList.ToList(); 
      orderForm.PizzaTypeList = _db.PizzaDefinition.ToList(); 
      orderForm.CrustList = _db.CrustDefinition.ToList(); 
      orderForm.SizeList = _db.SizeDefinition.ToList(); 
      orderForm.ToppingList = _db.ToppingDefinition.ToList(); 

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