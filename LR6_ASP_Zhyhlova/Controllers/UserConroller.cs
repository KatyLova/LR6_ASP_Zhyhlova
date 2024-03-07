using Microsoft.AspNetCore.Mvc;
using LR6_ASP_Zhyhlova.Models;

namespace LR6_ASP_Zhyhlova.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index() => View();

        [HttpPost]
        public IActionResult Index(User user)
        {
            return RedirectToAction("Index", "Products", new
            {
                amountOfProducts = user.AmountOfProducts,
                email = user.Email,
                age = user.Age
            });
        }
    }
}
