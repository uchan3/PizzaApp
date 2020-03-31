using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PizzaBox.Domain.Models;
using PizzaBox.MVCClient.Models;

namespace PizzaBox.MVCClient.Controllers
{
    public class HomeController : Controller
    {
        List<User> UserDirectory  = new List<User>()
        {
          new User { UserID = 1, FirstName = "John", LastName="Smith"}, 
          new User { UserID = 2, FirstName = "Joe", LastName="Cheung"}
        };

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult UserLogin()
        {
          
          return View(); 
        }

        [HttpPost]
        public IActionResult UserLogin(User loginInfo)
        {
          //TODO: Implement IEquatable in UserDirectory for the search to work. 
          foreach (var UserInfo in UserDirectory) 
          {
            if(UserInfo.FirstName == loginInfo.FirstName && UserInfo.LastName == loginInfo.LastName)
            {
              return RedirectToAction("UserOptions", "User");
            }
            else
            {
              return RedirectToAction("Index", "Home"); 
            }        
          }

          return View(); 
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
