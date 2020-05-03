using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PizzaBox.Domain.Models;
using PizzaBox.MVCClient.Models;
using PizzaBox.Data;

namespace PizzaBox.MVCClient.Controllers
{
    public class HomeController : Controller
    {
        private List<User> UserDirectory  = new List<User>()
        {
          new User { UserID = 1, FirstName = "John", LastName="Smith"}, 
          new User { UserID = 2, FirstName = "Joe", LastName="Cheung"}
        };
        
        // private PizzaBoxDBContext _db;

        // public HomeController(PizzaBoxDBContext db)
        // {
        //   _db = db;
        // }

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
          if (UserDirectory.Contains(loginInfo))
          {
            string UserName = loginInfo.FirstName + ' ' + loginInfo.LastName;
            TempData["UserInfo"] = UserName; //For now, store string in TempData.
            return RedirectToAction("UserOptions", "User"); 
          }
          else
          {
            ViewData["ErrorMessage"] = "Incorrect Login. Please try again."; 
            ModelState.Clear(); //Clears the values in the model. 
            return View(new User()); 
            //return RedirectToAction("Index", "Home");
          }
        }
        
        [HttpPost]
        public IActionResult Register(User registerInfo)
        {
          int UserID = UserDirectory.Count; //Get # of users in userdirectory. 
          registerInfo.UserID = UserID + 1; //Then, increment id by 1. 

          //Construct string to store in TempData. 
          string registerConfirm = "UserID: " + registerInfo.UserID + '\n' + 
          "Customer Name: " + registerInfo.FirstName + ' ' + registerInfo.LastName;
          TempData["RegisterInfo"] = registerConfirm;
          UserDirectory.Add(registerInfo);
          return RedirectToAction("Privacy", "Home"); 
          //For now, we redirect to "Privacy" method. May consider renaming "Privacy" method...
        }
        
        public IActionResult Privacy()
        {
          if(TempData["RegisterInfo"] != null)
          {
            string registerInfo = TempData["RegisterInfo"] as string;
            ViewData["NewUser"] = registerInfo;
          }
          else
          {
            ViewData["NewUser"] = "There is no new user information to display!";
          }
          return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
