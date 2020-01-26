using Microsoft.AspNetCore.Mvc;

namespace PizzaBox.MVCClient.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}