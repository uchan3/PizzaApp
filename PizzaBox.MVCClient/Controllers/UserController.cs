using Microsoft.AspNetCore.Mvc;

namespace PizzaBox.MVCClient.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public IActionResult UserOptions()
        {
            return View();
        }
    }
}