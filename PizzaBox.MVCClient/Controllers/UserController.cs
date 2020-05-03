using Microsoft.AspNetCore.Mvc;
using PizzaBox.Data;
using PizzaBox.Domain.Models;

namespace PizzaBox.MVCClient.Controllers
{
    public class UserController : Controller
    {
        // private PizzaBoxDBContext _db;

        // public UserController(PizzaBoxDBContext db)
        // {
        //   _db = db;
        // }
        
        [HttpGet]
        public IActionResult UserOptions()
        {
          //Check that TempData exists. 
          if (TempData["UserInfo"] != null)
          {
            string CustomerName =  TempData["UserInfo"] as string;
            ViewData["UserInfo"] = CustomerName;  
          }  
          //User could very well navigate to this action. 
          else
          {
            ViewData["Warning"] = "You are not authorized to view the information."; 
          }
          //TempData.Keep(); //This allows us to persist tempdata for next http request. 
          return View();
        }
    }
}